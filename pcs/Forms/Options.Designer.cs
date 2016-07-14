namespace pcs.Forms
{
    partial class Options
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
            this.btnChangeLanguage = new pcs.Components.Controls.PCSButton();
            this.checkAutosave = new pcs.Components.Controls.PCSCheckbox();
            this.tbSound = new pcs.Components.Controls.PCSTrackbar();
            this.tbMusic = new pcs.Components.Controls.PCSTrackbar();
            this.lblSound = new pcs.Components.Controls.PCSLabel();
            this.lblMusic = new pcs.Components.Controls.PCSLabel();
            this.SuspendLayout();
            // 
            // btnChangeLanguage
            // 
            this.btnChangeLanguage.Border = 0;
            this.btnChangeLanguage.Location = new System.Drawing.Point(12, 333);
            this.btnChangeLanguage.MouseUpState = PearXLib.Engine.Bases.XButtonState.FOCUSED;
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Size = new System.Drawing.Size(262, 41);
            this.btnChangeLanguage.TabIndex = 1;
            this.btnChangeLanguage.Text = "pcsButton1";
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // checkAutosave
            // 
            this.checkAutosave.ColorBGFocused = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.checkAutosave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.checkAutosave.Location = new System.Drawing.Point(12, 38);
            this.checkAutosave.Name = "checkAutosave";
            this.checkAutosave.Size = new System.Drawing.Size(160, 32);
            this.checkAutosave.TabIndex = 0;
            this.checkAutosave.Text = "pcsCheckbox1";
            this.checkAutosave.CheckedChanged += new PearXLib.Engine.Bases.CheckboxHandler(this.checkAutosave_CheckedChanged);
            // 
            // tbSound
            // 
            this.tbSound.Location = new System.Drawing.Point(85, 72);
            this.tbSound.Name = "tbSound";
            this.tbSound.PointerSize = ((short)(15));
            this.tbSound.Size = new System.Drawing.Size(262, 29);
            this.tbSound.TabIndex = 2;
            this.tbSound.ValueChanged += new PearXLib.Engine.BarEventHandler(this.tbSound_ValueChanged);
            // 
            // tbMusic
            // 
            this.tbMusic.Location = new System.Drawing.Point(85, 107);
            this.tbMusic.Name = "tbMusic";
            this.tbMusic.PointerSize = ((short)(15));
            this.tbMusic.Size = new System.Drawing.Size(262, 29);
            this.tbMusic.TabIndex = 3;
            this.tbMusic.ValueChanged += new PearXLib.Engine.BarEventHandler(this.tbMusic_ValueChanged);
            // 
            // lblSound
            // 
            this.lblSound.Location = new System.Drawing.Point(6, 73);
            this.lblSound.MaximumSize = new System.Drawing.Size(73, 28);
            this.lblSound.MinimumSize = new System.Drawing.Size(73, 28);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(73, 28);
            this.lblSound.TabIndex = 4;
            this.lblSound.Text = "pcsLabel1";
            // 
            // lblMusic
            // 
            this.lblMusic.Location = new System.Drawing.Point(6, 106);
            this.lblMusic.MaximumSize = new System.Drawing.Size(73, 28);
            this.lblMusic.MinimumSize = new System.Drawing.Size(73, 28);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(73, 28);
            this.lblMusic.TabIndex = 5;
            this.lblMusic.Text = "pcsLabel2";
            // 
            // Options
            // 
            this.ClientSize = new System.Drawing.Size(359, 386);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.tbMusic);
            this.Controls.Add(this.tbSound);
            this.Controls.Add(this.btnChangeLanguage);
            this.Controls.Add(this.checkAutosave);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Options";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Components.Controls.PCSCheckbox checkAutosave;
        public Components.Controls.PCSButton btnChangeLanguage;
        private Components.Controls.PCSTrackbar tbSound;
        private Components.Controls.PCSTrackbar tbMusic;
        public Components.Controls.PCSLabel lblSound;
        public Components.Controls.PCSLabel lblMusic;
    }
}