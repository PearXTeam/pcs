namespace pcs.Forms
{
    partial class Game
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
            this.barFood = new pcs.Components.PCSBar();
            this.barMood = new pcs.Components.PCSBar();
            this.barSleep = new pcs.Components.PCSBar();
            this.barHealth = new pcs.Components.PCSBar();
            this.SuspendLayout();
            // 
            // barFood
            // 
            this.barFood.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.barFood.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barFood.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barFood.Location = new System.Drawing.Point(596, 42);
            this.barFood.Name = "barFood";
            this.barFood.ProgressTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barFood.Size = new System.Drawing.Size(160, 28);
            this.barFood.TabIndex = 0;
            // 
            // barMood
            // 
            this.barMood.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.barMood.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barMood.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barMood.Location = new System.Drawing.Point(596, 76);
            this.barMood.Name = "barMood";
            this.barMood.ProgressTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barMood.Size = new System.Drawing.Size(160, 28);
            this.barMood.TabIndex = 1;
            // 
            // barSleep
            // 
            this.barSleep.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.barSleep.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barSleep.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barSleep.Location = new System.Drawing.Point(596, 110);
            this.barSleep.Name = "barSleep";
            this.barSleep.ProgressTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barSleep.Size = new System.Drawing.Size(160, 28);
            this.barSleep.TabIndex = 2;
            // 
            // barHealth
            // 
            this.barHealth.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.barHealth.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barHealth.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barHealth.Location = new System.Drawing.Point(596, 144);
            this.barHealth.Name = "barHealth";
            this.barHealth.ProgressTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barHealth.Size = new System.Drawing.Size(160, 28);
            this.barHealth.TabIndex = 3;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.barHealth);
            this.Controls.Add(this.barSleep);
            this.Controls.Add(this.barMood);
            this.Controls.Add(this.barFood);
            this.Name = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        public Components.PCSBar barFood;
        public Components.PCSBar barHealth;
        public Components.PCSBar barSleep;
        public Components.PCSBar barMood;
    }
}