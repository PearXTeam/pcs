namespace pcs.Forms
{
    partial class About
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
            this.lblMsg = new pcs.Components.PCSLabel();
            this.btnGithub = new pcs.Components.PCSButton();
            this.btnWebsite = new pcs.Components.PCSButton();
            this.btnDiscord = new pcs.Components.PCSButton();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.DrawInRectangle = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 41);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.ShadowOffset = ((short)(2));
            this.lblMsg.Size = new System.Drawing.Size(394, 284);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "pcsLabel1";
            this.lblMsg.UseInterpolation = false;
            // 
            // btnGithub
            // 
            this.btnGithub.Border = 0;
            this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGithub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGithub.Location = new System.Drawing.Point(12, 331);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.ShadowOffset = ((short)(2));
            this.btnGithub.Size = new System.Drawing.Size(128, 34);
            this.btnGithub.TabIndex = 1;
            this.btnGithub.Text = "A button.";
            this.btnGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGithub.UseInterpolation = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnWebsite
            // 
            this.btnWebsite.Border = 0;
            this.btnWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWebsite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWebsite.Location = new System.Drawing.Point(146, 331);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.ShadowOffset = ((short)(2));
            this.btnWebsite.Size = new System.Drawing.Size(128, 34);
            this.btnWebsite.TabIndex = 2;
            this.btnWebsite.Text = "A button.";
            this.btnWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWebsite.UseInterpolation = false;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // btnDiscord
            // 
            this.btnDiscord.Border = 0;
            this.btnDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscord.Location = new System.Drawing.Point(280, 331);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.ShadowOffset = ((short)(2));
            this.btnDiscord.Size = new System.Drawing.Size(128, 34);
            this.btnDiscord.TabIndex = 3;
            this.btnDiscord.Text = "A button.";
            this.btnDiscord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDiscord.UseInterpolation = false;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // About
            // 
            this.ClientSize = new System.Drawing.Size(418, 377);
            this.Controls.Add(this.btnDiscord);
            this.Controls.Add(this.btnWebsite);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.lblMsg);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Components.PCSLabel lblMsg;
        public pcs.Components.PCSButton btnDiscord;
        public pcs.Components.PCSButton btnWebsite;
        public pcs.Components.PCSButton btnGithub;
    }
}