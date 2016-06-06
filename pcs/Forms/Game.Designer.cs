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
            this.panelIcons = new System.Windows.Forms.Panel();
            this.lblTime = new pcs.Components.Controls.PCSLabel();
            this.panelToolIcons = new System.Windows.Forms.Panel();
            this.lblXP = new pcs.Components.Controls.PCSLabel();
            this.lblMoney = new pcs.Components.Controls.PCSLabel();
            this.barHealth = new pcs.Components.Controls.PCSBar();
            this.barSleep = new pcs.Components.Controls.PCSBar();
            this.barMood = new pcs.Components.Controls.PCSBar();
            this.barFood = new pcs.Components.Controls.PCSBar();
            this.SuspendLayout();
            // 
            // panelIcons
            // 
            this.panelIcons.AutoScroll = true;
            this.panelIcons.Location = new System.Drawing.Point(12, 41);
            this.panelIcons.Name = "panelIcons";
            this.panelIcons.Size = new System.Drawing.Size(640, 344);
            this.panelIcons.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(620, 472);
            this.lblTime.MaximumSize = new System.Drawing.Size(136, 28);
            this.lblTime.MinimumSize = new System.Drawing.Size(136, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 28);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "00:00, 27.05.2004";
            // 
            // panelToolIcons
            // 
            this.panelToolIcons.AutoScroll = true;
            this.panelToolIcons.Location = new System.Drawing.Point(697, 41);
            this.panelToolIcons.Name = "panelToolIcons";
            this.panelToolIcons.Size = new System.Drawing.Size(66, 344);
            this.panelToolIcons.TabIndex = 6;
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Font = new System.Drawing.Font("Yanone Kaffeesatz", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblXP.Location = new System.Drawing.Point(384, 428);
            this.lblXP.MaximumSize = new System.Drawing.Size(83, 31);
            this.lblXP.MinimumSize = new System.Drawing.Size(83, 31);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(83, 31);
            this.lblXP.TabIndex = 5;
            this.lblXP.Text = "pcsLabel1";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Yanone Kaffeesatz", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoney.Location = new System.Drawing.Point(12, 428);
            this.lblMoney.MaximumSize = new System.Drawing.Size(83, 31);
            this.lblMoney.MinimumSize = new System.Drawing.Size(83, 31);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(83, 31);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "pcsLabel1";
            // 
            // barHealth
            // 
            this.barHealth.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.barHealth.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barHealth.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barHealth.Location = new System.Drawing.Point(571, 391);
            this.barHealth.Name = "barHealth";
            this.barHealth.Size = new System.Drawing.Size(180, 34);
            this.barHealth.TabIndex = 3;
            // 
            // barSleep
            // 
            this.barSleep.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.barSleep.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barSleep.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barSleep.Location = new System.Drawing.Point(385, 391);
            this.barSleep.Name = "barSleep";
            this.barSleep.Size = new System.Drawing.Size(180, 34);
            this.barSleep.TabIndex = 2;
            // 
            // barMood
            // 
            this.barMood.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.barMood.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barMood.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barMood.Location = new System.Drawing.Point(199, 391);
            this.barMood.Name = "barMood";
            this.barMood.Size = new System.Drawing.Size(180, 34);
            this.barMood.TabIndex = 1;
            // 
            // barFood
            // 
            this.barFood.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.barFood.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barFood.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.barFood.Location = new System.Drawing.Point(13, 391);
            this.barFood.Name = "barFood";
            this.barFood.Size = new System.Drawing.Size(180, 34);
            this.barFood.TabIndex = 0;
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.panelIcons);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panelToolIcons);
            this.Controls.Add(this.lblXP);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.barHealth);
            this.Controls.Add(this.barSleep);
            this.Controls.Add(this.barMood);
            this.Controls.Add(this.barFood);
            this.KeyPreview = true;
            this.Name = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Components.Controls.PCSBar barFood;
        public Components.Controls.PCSBar barHealth;
        public Components.Controls.PCSBar barSleep;
        public Components.Controls.PCSBar barMood;
        public Components.Controls.PCSLabel lblMoney;
        public Components.Controls.PCSLabel lblXP;
        public System.Windows.Forms.Panel panelToolIcons;
        public Components.Controls.PCSLabel lblTime;
        public System.Windows.Forms.Panel panelIcons;
    }
}