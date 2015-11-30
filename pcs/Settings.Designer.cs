namespace pcs
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialogBG = new System.Windows.Forms.ColorDialog();
            this.BGColor = new System.Windows.Forms.PictureBox();
            this.buttonSelectBGColor = new PearXLib.Engine.XButton();
            this.buttonSelectWallpaper = new PearXLib.Engine.XButton();
            this.openFileDialogWallpaper = new System.Windows.Forms.OpenFileDialog();
            this.buttonDeleteWallpapers = new PearXLib.Engine.XButton();
            ((System.ComponentModel.ISupportInitialize)(this.BGColor)).BeginInit();
            this.SuspendLayout();
            // 
            // BGColor
            // 
            this.BGColor.Location = new System.Drawing.Point(146, 13);
            this.BGColor.Name = "BGColor";
            this.BGColor.Size = new System.Drawing.Size(28, 37);
            this.BGColor.TabIndex = 1;
            this.BGColor.TabStop = false;
            // 
            // buttonSelectBGColor
            // 
            this.buttonSelectBGColor.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectBGColor.ColorPressed = System.Drawing.Color.Gold;
            this.buttonSelectBGColor.GradientColor1 = System.Drawing.Color.DarkOrange;
            this.buttonSelectBGColor.GradientColorFocused1 = System.Drawing.Color.Orange;
            this.buttonSelectBGColor.Location = new System.Drawing.Point(12, 12);
            this.buttonSelectBGColor.Name = "buttonSelectBGColor";
            this.buttonSelectBGColor.Size = new System.Drawing.Size(128, 38);
            this.buttonSelectBGColor.TabIndex = 0;
            this.buttonSelectBGColor.Click += new System.EventHandler(this.buttonSelectBGColor_Click);
            // 
            // buttonSelectWallpaper
            // 
            this.buttonSelectWallpaper.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectWallpaper.ColorPressed = System.Drawing.Color.Gold;
            this.buttonSelectWallpaper.GradientColor1 = System.Drawing.Color.DarkOrange;
            this.buttonSelectWallpaper.GradientColorFocused1 = System.Drawing.Color.Orange;
            this.buttonSelectWallpaper.Location = new System.Drawing.Point(12, 56);
            this.buttonSelectWallpaper.Name = "buttonSelectWallpaper";
            this.buttonSelectWallpaper.Size = new System.Drawing.Size(128, 38);
            this.buttonSelectWallpaper.TabIndex = 2;
            this.buttonSelectWallpaper.Click += new System.EventHandler(this.buttonSelectWallpaper_Click);
            // 
            // openFileDialogWallpaper
            // 
            this.openFileDialogWallpaper.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogWallpaper_FileOk);
            // 
            // buttonDeleteWallpapers
            // 
            this.buttonDeleteWallpapers.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteWallpapers.ButtonText = "X";
            this.buttonDeleteWallpapers.ColorPressed = System.Drawing.Color.Gold;
            this.buttonDeleteWallpapers.GradientColor1 = System.Drawing.Color.DarkOrange;
            this.buttonDeleteWallpapers.GradientColorFocused1 = System.Drawing.Color.Orange;
            this.buttonDeleteWallpapers.Location = new System.Drawing.Point(139, 56);
            this.buttonDeleteWallpapers.Name = "buttonDeleteWallpapers";
            this.buttonDeleteWallpapers.Size = new System.Drawing.Size(28, 38);
            this.buttonDeleteWallpapers.TabIndex = 3;
            this.buttonDeleteWallpapers.Click += new System.EventHandler(this.buttonDeleteWallpapers_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonDeleteWallpapers);
            this.Controls.Add(this.buttonSelectWallpaper);
            this.Controls.Add(this.BGColor);
            this.Controls.Add(this.buttonSelectBGColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BGColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialogBG;
        private PearXLib.Engine.XButton buttonSelectBGColor;
        private System.Windows.Forms.PictureBox BGColor;
        private PearXLib.Engine.XButton buttonSelectWallpaper;
        private System.Windows.Forms.OpenFileDialog openFileDialogWallpaper;
        private PearXLib.Engine.XButton buttonDeleteWallpapers;
    }
}