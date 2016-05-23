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
            this.checkAutosave = new pcs.Components.Controls.PCSCheckbox();
            this.btnChangeLanguage = new pcs.Components.Controls.PCSButton();
            this.SuspendLayout();
            // 
            // checkAutosave
            // 
            this.checkAutosave.ColorBGFocused = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.checkAutosave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAutosave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.checkAutosave.Location = new System.Drawing.Point(12, 38);
            this.checkAutosave.Name = "checkAutosave";
            this.checkAutosave.Size = new System.Drawing.Size(160, 32);
            this.checkAutosave.TabIndex = 0;
            this.checkAutosave.Text = "pcsCheckbox1";
            this.checkAutosave.CheckedChanged += new PearXLib.Engine.XCheckboxBase.CheckboxHandler(this.checkAutosave_CheckedChanged);
            // 
            // btnChangeLanguage
            // 
            this.btnChangeLanguage.Border = 0;
            this.btnChangeLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeLanguage.Location = new System.Drawing.Point(12, 333);
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Size = new System.Drawing.Size(262, 41);
            this.btnChangeLanguage.TabIndex = 1;
            this.btnChangeLanguage.Text = "pcsButton1";
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // Options
            // 
            this.ClientSize = new System.Drawing.Size(286, 386);
            this.Controls.Add(this.btnChangeLanguage);
            this.Controls.Add(this.checkAutosave);
            this.Name = "Options";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Components.Controls.PCSCheckbox checkAutosave;
        public Components.Controls.PCSButton btnChangeLanguage;
    }
}