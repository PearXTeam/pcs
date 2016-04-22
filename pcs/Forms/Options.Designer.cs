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
            this.checkAutosave = new pcs.Components.PCSCheckbox();
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
            // Options
            // 
            this.ClientSize = new System.Drawing.Size(286, 386);
            this.Controls.Add(this.checkAutosave);
            this.Name = "Options";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Components.PCSCheckbox checkAutosave;
    }
}