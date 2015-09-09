namespace pcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSite = new System.Windows.Forms.Button();
            this.buttonGitHub = new System.Windows.Forms.Button();
            this.buttonVK = new System.Windows.Forms.Button();
            this.buttonYT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PCSimulator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 93);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игра-симулятор жизни с\r\nоткрытым исходным кодом.\r\nИгра написана на C#.\r\n";
            // 
            // buttonSite
            // 
            this.buttonSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSite.Location = new System.Drawing.Point(19, 157);
            this.buttonSite.Name = "buttonSite";
            this.buttonSite.Size = new System.Drawing.Size(107, 32);
            this.buttonSite.TabIndex = 2;
            this.buttonSite.Text = "Сайт";
            this.buttonSite.UseVisualStyleBackColor = true;
            this.buttonSite.Click += new System.EventHandler(this.buttonSite_Click);
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGitHub.Location = new System.Drawing.Point(131, 157);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(107, 32);
            this.buttonGitHub.TabIndex = 3;
            this.buttonGitHub.Text = "GitHub";
            this.buttonGitHub.UseVisualStyleBackColor = true;
            this.buttonGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            // 
            // buttonVK
            // 
            this.buttonVK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVK.Location = new System.Drawing.Point(244, 157);
            this.buttonVK.Name = "buttonVK";
            this.buttonVK.Size = new System.Drawing.Size(107, 32);
            this.buttonVK.TabIndex = 4;
            this.buttonVK.Text = "VK";
            this.buttonVK.UseVisualStyleBackColor = true;
            this.buttonVK.Click += new System.EventHandler(this.buttonVK_Click);
            // 
            // buttonYT
            // 
            this.buttonYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYT.Location = new System.Drawing.Point(131, 195);
            this.buttonYT.Name = "buttonYT";
            this.buttonYT.Size = new System.Drawing.Size(107, 32);
            this.buttonYT.TabIndex = 5;
            this.buttonYT.Text = "YouTube";
            this.buttonYT.UseVisualStyleBackColor = true;
            this.buttonYT.Click += new System.EventHandler(this.buttonYT_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(374, 240);
            this.Controls.Add(this.buttonYT);
            this.Controls.Add(this.buttonVK);
            this.Controls.Add(this.buttonGitHub);
            this.Controls.Add(this.buttonSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "About";
            this.Text = "О игре";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSite;
        private System.Windows.Forms.Button buttonGitHub;
        private System.Windows.Forms.Button buttonVK;
        private System.Windows.Forms.Button buttonYT;
    }
}