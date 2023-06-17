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

        private void SaveSettings()
        {
            Properties.Settings.Default.StartupPath = StartupFolderTB.Text;
        }

        private void StartupFolderBT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult res = fbd.ShowDialog();
            if (res != DialogResult.OK) return;

            StartupFolderTB.Text = fbd.SelectedPath;

        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
