[CmdletBinding()]
param (
    [Parameter(Mandatory)]
    [String]$Version,
    [String]$AssemblyFile
)

# This assists in the auto update of the Application and File Version
# Called by Pre-build event
# Deleted after build

$AssemblyFile = $AssemblyFile.replace("'","")
$Version = $Version.replace("'","")

Write-Host "Version: $Version"
Write-Host "Assembly File: $AssemblyFile"

$content = Get-Content -path $AssemblyFile

$newAssemblyVersion = "AssemblyVersion(""" + $Version + """)"
$newAssemblyFileVersion = "AssemblyFileVersion(""" + $Version + """)"

$content = $content -CReplace 'AssemblyVersion\("(\d+).(\d+).(\d+).(\d+)"\)', $newAssemblyVersion
$content = $content -CReplace 'AssemblyFileVersion\("(\d+).(\d+).(\d+).(\d+)"\)', $newAssemblyFileVersion

Out-File -FilePath $AssemblyFile -InputObject $content -encoding ASCII

Write-Host "AssemblyInfo file updated successfully"