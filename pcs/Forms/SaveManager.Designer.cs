namespace pcs.Forms
{
    partial class SaveManager
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
            this.panelSaves = new System.Windows.Forms.Panel();
            this.buttonSave = new PearXLib.Engine.Flat.FlatButton();
            this.SuspendLayout();
            // 
            // panelSaves
            // 
            this.panelSaves.AutoScroll = true;
            this.panelSaves.Location = new System.Drawing.Point(12, 41);
            this.panelSaves.Name = "panelSaves";
            this.panelSaves.Size = new System.Drawing.Size(354, 296);
            this.panelSaves.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Border = 0;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.Location = new System.Drawing.Point(12, 343);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(354, 64);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "A button.";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SaveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 418);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelSaves);
            this.Name = "SaveManager";
            this.Text = "SaveManager";
            this.Shown += new System.EventHandler(this.SaveManager_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSaves;
        public PearXLib.Engine.Flat.FlatButton buttonSave;
    }
}