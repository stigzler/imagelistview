using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manina.Windows.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.OverlayImageSize = new Size((int)OverlayImageWNUM.Value, (int)OverlayImageHNUM.Value);

            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            OverlayImageHNUM.Value = Properties.Settings.Default.OverlayImageSize.Height;
            OverlayImageWNUM.Value = Properties.Settings.Default.OverlayImageSize.Width;
        }

        private void StartupFolderBT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult res = fbd.ShowDialog();
            if (res != DialogResult.OK) return;


        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
