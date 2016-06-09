namespace pcs.Forms
{
    partial class MiniGamesGUI
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
            this.panelMg = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelMg
            // 
            this.panelMg.AutoScroll = true;
            this.panelMg.Location = new System.Drawing.Point(12, 40);
            this.panelMg.Name = "panelMg";
            this.panelMg.Size = new System.Drawing.Size(384, 471);
            this.panelMg.TabIndex = 0;
            // 
            // MiniGamesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 522);
            this.Controls.Add(this.panelMg);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MiniGamesGUI";
            this.Text = "MiniGamesGUI";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMg;
    }
}