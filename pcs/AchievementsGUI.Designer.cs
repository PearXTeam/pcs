namespace pcs
{
    partial class AchievementsGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AchievementsGUI));
            this.imageAchLie = new System.Windows.Forms.PictureBox();
            this.labelAchLie = new System.Windows.Forms.Label();
            this.labelAchLieDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageAchLie)).BeginInit();
            this.SuspendLayout();
            // 
            // imageAchLie
            // 
            this.imageAchLie.Location = new System.Drawing.Point(12, 12);
            this.imageAchLie.Name = "imageAchLie";
            this.imageAchLie.Size = new System.Drawing.Size(64, 64);
            this.imageAchLie.TabIndex = 0;
            this.imageAchLie.TabStop = false;
            // 
            // labelAchLie
            // 
            this.labelAchLie.AutoSize = true;
            this.labelAchLie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAchLie.ForeColor = System.Drawing.Color.Red;
            this.labelAchLie.Location = new System.Drawing.Point(82, 12);
            this.labelAchLie.Name = "labelAchLie";
            this.labelAchLie.Size = new System.Drawing.Size(65, 25);
            this.labelAchLie.TabIndex = 1;
            this.labelAchLie.Text = "Ложь";
            // 
            // labelAchLieDesc
            // 
            this.labelAchLieDesc.AutoSize = true;
            this.labelAchLieDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAchLieDesc.ForeColor = System.Drawing.Color.Blue;
            this.labelAchLieDesc.Location = new System.Drawing.Point(83, 37);
            this.labelAchLieDesc.Name = "labelAchLieDesc";
            this.labelAchLieDesc.Size = new System.Drawing.Size(141, 20);
            this.labelAchLieDesc.TabIndex = 2;
            this.labelAchLieDesc.Text = "Съешьте тортик.";
            // 
            // AchievementsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 293);
            this.Controls.Add(this.labelAchLieDesc);
            this.Controls.Add(this.labelAchLie);
            this.Controls.Add(this.imageAchLie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AchievementsGUI";
            this.Text = "Достижения";
            this.Load += new System.EventHandler(this.AchievementsGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageAchLie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageAchLie;
        private System.Windows.Forms.Label labelAchLie;
        private System.Windows.Forms.Label labelAchLieDesc;
    }
}