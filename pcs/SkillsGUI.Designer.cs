namespace pcs
{
    partial class SkillsGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillsGUI));
            this.labelSkillEnglish = new System.Windows.Forms.Label();
            this.labelSkillLiteracy = new System.Windows.Forms.Label();
            this.labelSkillComputer = new System.Windows.Forms.Label();
            this.labelSkillAdvancedMath = new System.Windows.Forms.Label();
            this.labelSkillCpp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSkillEnglish
            // 
            this.labelSkillEnglish.AutoSize = true;
            this.labelSkillEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkillEnglish.ForeColor = System.Drawing.Color.Green;
            this.labelSkillEnglish.Location = new System.Drawing.Point(12, 9);
            this.labelSkillEnglish.Name = "labelSkillEnglish";
            this.labelSkillEnglish.Size = new System.Drawing.Size(51, 20);
            this.labelSkillEnglish.TabIndex = 0;
            this.labelSkillEnglish.Text = "label1";
            // 
            // labelSkillLiteracy
            // 
            this.labelSkillLiteracy.AutoSize = true;
            this.labelSkillLiteracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkillLiteracy.ForeColor = System.Drawing.Color.Green;
            this.labelSkillLiteracy.Location = new System.Drawing.Point(12, 29);
            this.labelSkillLiteracy.Name = "labelSkillLiteracy";
            this.labelSkillLiteracy.Size = new System.Drawing.Size(51, 20);
            this.labelSkillLiteracy.TabIndex = 1;
            this.labelSkillLiteracy.Text = "label1";
            // 
            // labelSkillComputer
            // 
            this.labelSkillComputer.AutoSize = true;
            this.labelSkillComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkillComputer.ForeColor = System.Drawing.Color.Green;
            this.labelSkillComputer.Location = new System.Drawing.Point(12, 49);
            this.labelSkillComputer.Name = "labelSkillComputer";
            this.labelSkillComputer.Size = new System.Drawing.Size(51, 20);
            this.labelSkillComputer.TabIndex = 2;
            this.labelSkillComputer.Text = "label1";
            // 
            // labelSkillAdvancedMath
            // 
            this.labelSkillAdvancedMath.AutoSize = true;
            this.labelSkillAdvancedMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkillAdvancedMath.ForeColor = System.Drawing.Color.Green;
            this.labelSkillAdvancedMath.Location = new System.Drawing.Point(12, 69);
            this.labelSkillAdvancedMath.Name = "labelSkillAdvancedMath";
            this.labelSkillAdvancedMath.Size = new System.Drawing.Size(51, 20);
            this.labelSkillAdvancedMath.TabIndex = 3;
            this.labelSkillAdvancedMath.Text = "label1";
            // 
            // labelSkillCpp
            // 
            this.labelSkillCpp.AutoSize = true;
            this.labelSkillCpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkillCpp.ForeColor = System.Drawing.Color.Green;
            this.labelSkillCpp.Location = new System.Drawing.Point(12, 89);
            this.labelSkillCpp.Name = "labelSkillCpp";
            this.labelSkillCpp.Size = new System.Drawing.Size(51, 20);
            this.labelSkillCpp.TabIndex = 4;
            this.labelSkillCpp.Text = "label1";
            // 
            // SkillsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 126);
            this.Controls.Add(this.labelSkillCpp);
            this.Controls.Add(this.labelSkillAdvancedMath);
            this.Controls.Add(this.labelSkillComputer);
            this.Controls.Add(this.labelSkillLiteracy);
            this.Controls.Add(this.labelSkillEnglish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SkillsGUI";
            this.Text = "Умения";
            this.Load += new System.EventHandler(this.SkillsGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSkillEnglish;
        private System.Windows.Forms.Label labelSkillLiteracy;
        private System.Windows.Forms.Label labelSkillComputer;
        private System.Windows.Forms.Label labelSkillAdvancedMath;
        private System.Windows.Forms.Label labelSkillCpp;

    }
}