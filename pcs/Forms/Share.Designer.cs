namespace pcs.Forms
{
    partial class Share
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
            this.btnShareVK = new pcs.Components.PCSButton();
            this.btnShareTwitter = new pcs.Components.PCSButton();
            this.SuspendLayout();
            // 
            // btnShareVK
            // 
            this.btnShareVK.Border = 0;
            this.btnShareVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShareVK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShareVK.Location = new System.Drawing.Point(12, 42);
            this.btnShareVK.Name = "btnShareVK";
            this.btnShareVK.Size = new System.Drawing.Size(257, 64);
            this.btnShareVK.TabIndex = 0;
            this.btnShareVK.Text = "pcsButton1";
            this.btnShareVK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShareVK.Click += new System.EventHandler(this.btnShareVK_Click);
            // 
            // btnShareTwitter
            // 
            this.btnShareTwitter.Border = 0;
            this.btnShareTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShareTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShareTwitter.Location = new System.Drawing.Point(12, 112);
            this.btnShareTwitter.Name = "btnShareTwitter";
            this.btnShareTwitter.Size = new System.Drawing.Size(257, 64);
            this.btnShareTwitter.TabIndex = 1;
            this.btnShareTwitter.Text = "pcsButton1";
            this.btnShareTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShareTwitter.Click += new System.EventHandler(this.btnShareTwitter_Click);
            // 
            // Share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 200);
            this.Controls.Add(this.btnShareTwitter);
            this.Controls.Add(this.btnShareVK);
            this.Name = "Share";
            this.Text = "ShareSocial";
            this.ResumeLayout(false);

        }

        #endregion

        public Components.PCSButton btnShareVK;
        public Components.PCSButton btnShareTwitter;
    }
}