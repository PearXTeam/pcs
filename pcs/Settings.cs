using PearXLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Text = v.l.GetString("title.settings");
            buttonSelectBGColor.ButtonText = v.l.GetString("settings.selectBGColor");
            buttonSelectWallpaper.ButtonText = v.l.GetString("settings.selectWallpaper");
            openFileDialogWallpaper.Filter = v.l.GetString("settings.filterImages") + "|*.bmp;*.jpg;*.png;*.jpeg;*.gif|" + v.l.GetString("settings.filterAllFiles") + "|*.*";
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Location = PXL.GetFormStartPosition(v.g, this);
            BGColor.BackColor = v.BGColor;
        }

        private void buttonSelectBGColor_Click(object sender, EventArgs e)
        {
            colorDialogBG.ShowDialog();
            BGColor.BackColor = colorDialogBG.Color;
            v.BGColor = colorDialogBG.Color;
        }

        private void buttonSelectWallpaper_Click(object sender, EventArgs e)
        {
            openFileDialogWallpaper.ShowDialog();
        }

        private void openFileDialogWallpaper_FileOk(object sender, CancelEventArgs e)
        {
            v.Wallpaper = openFileDialogWallpaper.FileName;
        }

        private void buttonDeleteWallpapers_Click(object sender, EventArgs e)
        {
            v.Wallpaper = null;
        }
    }
}
