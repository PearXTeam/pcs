namespace pcs
{
    partial class UpdaterGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdaterGUI));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.runUpd = new System.Windows.Forms.Button();
            this.labelActual = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(279, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(354, 321);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://pcs.pearx.ru/changelog.html", System.UriKind.Absolute);
            // 
            // runUpd
            // 
            this.runUpd.Location = new System.Drawing.Point(12, 270);
            this.runUpd.Name = "runUpd";
            this.runUpd.Size = new System.Drawing.Size(261, 36);
            this.runUpd.TabIndex = 2;
            this.runUpd.Text = "Обновить";
            this.runUpd.UseVisualStyleBackColor = true;
            this.runUpd.Click += new System.EventHandler(this.runUpd_Click);
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActual.Location = new System.Drawing.Point(12, 9);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(51, 20);
            this.labelActual.TabIndex = 3;
            this.labelActual.Text = "label1";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.Location = new System.Drawing.Point(12, 29);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(51, 20);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "label1";
            // 
            // UpdaterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 318);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelActual);
            this.Controls.Add(this.runUpd);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdaterGUI";
            this.Text = "Менеджер обновлений";
            this.Load += new System.EventHandler(this.UpdaterGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button runUpd;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.Label labelVersion;
    }
}