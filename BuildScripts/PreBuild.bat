::Error Thrown by Pre-Build Script
@echo off
setlocal ENABLEDELAYEDEXPANSION

:: ==============================================================================================
:: Automated Visual Studio Deployment Script
:: ? stigzler 2022 - free for non-commercial use
:: PRE-BUILD SCRIPT

:: PRE-REQUISITE:
:: You will require the file psReplace.ps1 in the same directory as this script
:: You should create a Shared Project in your Solution and Create a folder called BuildScripts in it. Place this file in there.
::
:: Automatically increases Version numbers
:: Out of the box, it increases the Build number in standard SemVer
:: You can either add MajorRelease, MinorRelease, RevisionRelease Configs to your Solution 
:: build types, or change the vars below to match the different configs in your solution
:: to be able to update the other segments in the version number.
:: Paste the below verbatim in your Pre-Build box:#
::
:: $(SolutionDir)BuildScripts\PreBuild.bat "$(ConfigurationName)" "$(ProjectDir)" "$(SolutionDir)"
::
:: If you have a solution where you will have more than one deployment assembly, you can 
:: place the pre and post build scripts in the Solution folder under a folder called BuildScripts
:: and change the above to $(ProjectDir)
:: ==============================================================================================
:: USER VARS: 
:: ==============================================================================================
set "autoIncreaseOff=False"
set "majorReleaseName=MajorRelease"
set "minorReleaseName=MinorRelease"
set "buildReleaseName=Release"
set "revisionReleaseName=Debug without WPF"
:: ==============================================================================================

echo ==========================
echo PRE-BUILD EVENTS
echo ==========================

set "ConfigurationName=%~1"
set "ProjectDir=%~2"
set "SolutionDir=%~3"

echo Recieved, de-quoted parameters:
echo Build Config Name: [!ConfigurationName!]
echo ProjectDir: [!ProjectDir!]
	
if [!autoIncreaseOff!]==[True] (
	echo Auto Increase Version number switched off
	Goto :skipAutoIncrease
	)	

set version=0.0.0.0
:: For vb change below to: 
:: FOR /F delims^=^"^ tokens^=2 %%i in ('findstr /b /c:"<Assembly: AssemblyVersion(" !ProjectDir!\AssemblyInfo.vb') do (
FOR /F delims^=^"^ tokens^=2 %%i in ('findstr /b /c:"[assembly: AssemblyVersion(" !ProjectDir!Properties\AssemblyInfo.cs') do (
  set version=%%i
)

for /F "tokens=1,2,3,4 delims=." %%a in ("!version!") do (
	set concatVersion=%%a.%%b.%%c
	set /a presentMajor=%%a
	set /a presentMinor=%%b
	set /a presentBuild=%%c
	set /a presentRevision=%%d
	)

echo Present Assembly Version: !version!

if [!ConfigurationName!]==[!majorReleaseName!] (
	echo The Build Config is a MAJOR Release
	set /a presentMajor+=1
	set /a presentMinor=0
	set /a presentBuild=0
	set /a presentRevision=0
	) else if [!ConfigurationName!]==[!minorReleaseName!] (
	echo The Build Config is a MINOR Release
	set /a presentMinor+=1
	set /a presentBuild=0
	set /a presentRevision=0
	) else if [!ConfigurationName!]==[!buildReleaseName!] (
	echo The Build Config is a BUILD Release
	set /a presentBuild+=1
	set /a presentRevision=0
	) else if [!ConfigurationName!]==[!revisionReleaseName!] (
	echo The Build Config is a REVISION Release
	set /a presentRevision+=1
	) else (
	echo NOT A DEPLOYMENT BUILD
	echo Not changing the Version number
	goto :skipAutoIncrease
	)
	
echo Auto incrementing Assembly Version Build number given Build Configuration
set updatedVersion=!presentMajor!.!presentMinor!.!presentBuild!.!presentRevision!
echo New AssemblyVersion: !updatedVersion!

echo Updating Version Number in AssemblyInfo.cs...

:: for c# - change below to:
 powershell.exe -ExecutionPolicy Bypass -File "!SolutionDir!BuildScripts\psReplace.ps1" -Version '!updatedVersion!' -AssemblyFile '!ProjectDir!Properties\AssemblyInfo.cs'
:: powershell.exe -ExecutionPolicy Bypass -File "!SolutionDir!BuildScripts\psReplace.ps1" -Version '!updatedVersion!' -AssemblyFile '!ProjectDir!AssemblyInfo.vb'

:skipAutoIncrease

echo PreBuild Events finished. \o/