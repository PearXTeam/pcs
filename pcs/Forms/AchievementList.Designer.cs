namespace pcs.Forms
{
    partial class AchievementList
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
            this.panelAchievements = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelAchievements
            // 
            this.panelAchievements.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panelAchievements.Location = new System.Drawing.Point(1, 33);
            this.panelAchievements.Name = "panelAchievements";
            this.panelAchievements.Size = new System.Drawing.Size(411, 418);
            this.panelAchievements.TabIndex = 0;
            // 
            // AchievementList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 452);
            this.Controls.Add(this.panelAchievements);
            this.Name = "AchievementList";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelAchievements;
    }
}