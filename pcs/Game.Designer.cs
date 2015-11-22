namespace pcs
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
            this.components = new System.ComponentModel.Container();
            this.panelIcons = new System.Windows.Forms.Panel();
            this.timerFood = new System.Windows.Forms.Timer(this.components);
            this.timerSleep = new System.Windows.Forms.Timer(this.components);
            this.timerMood = new System.Windows.Forms.Timer(this.components);
            this.timerPurity = new System.Windows.Forms.Timer(this.components);
            this.labelMoneys = new System.Windows.Forms.Label();
            this.labelXP = new System.Windows.Forms.Label();
            this.panelMiniIcons = new System.Windows.Forms.Panel();
            this.barHealth = new PearXLib.Engine.XBar();
            this.barSleep = new PearXLib.Engine.XBar();
            this.barPurity = new PearXLib.Engine.XBar();
            this.barMood = new PearXLib.Engine.XBar();
            this.barFood = new PearXLib.Engine.XBar();
            this.SuspendLayout();
            // 
            // panelIcons
            // 
            this.panelIcons.AutoScroll = true;
            this.panelIcons.BackColor = System.Drawing.Color.Transparent;
            this.panelIcons.Location = new System.Drawing.Point(0, 0);
            this.panelIcons.Name = "panelIcons";
            this.panelIcons.Size = new System.Drawing.Size(810, 325);
            this.panelIcons.TabIndex = 4;
            // 
            // timerFood
            // 
            this.timerFood.Interval = 9000;
            this.timerFood.Tick += new System.EventHandler(this.timerFood_Tick);
            // 
            // timerSleep
            // 
            this.timerSleep.Interval = 1500;
            this.timerSleep.Tick += new System.EventHandler(this.timerSleep_Tick);
            // 
            // timerMood
            // 
            this.timerMood.Interval = 18000;
            this.timerMood.Tick += new System.EventHandler(this.timerMood_Tick);
            // 
            // timerPurity
            // 
            this.timerPurity.Interval = 15000;
            this.timerPurity.Tick += new System.EventHandler(this.timerPurity_Tick);
            // 
            // labelMoneys
            // 
            this.labelMoneys.AutoSize = true;
            this.labelMoneys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoneys.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelMoneys.Location = new System.Drawing.Point(45, 377);
            this.labelMoneys.Name = "labelMoneys";
            this.labelMoneys.Size = new System.Drawing.Size(87, 24);
            this.labelMoneys.TabIndex = 9;
            this.labelMoneys.Text = "Moneys: ";
            // 
            // labelXP
            // 
            this.labelXP.AutoSize = true;
            this.labelXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXP.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelXP.Location = new System.Drawing.Point(45, 401);
            this.labelXP.Name = "labelXP";
            this.labelXP.Size = new System.Drawing.Size(46, 24);
            this.labelXP.TabIndex = 10;
            this.labelXP.Text = "XP: ";
            // 
            // panelMiniIcons
            // 
            this.panelMiniIcons.AutoScroll = true;
            this.panelMiniIcons.Location = new System.Drawing.Point(634, 387);
            this.panelMiniIcons.Name = "panelMiniIcons";
            this.panelMiniIcons.Size = new System.Drawing.Size(158, 74);
            this.panelMiniIcons.TabIndex = 11;
            // 
            // barHealth
            // 
            this.barHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barHealth.GradientColor1 = System.Drawing.Color.Red;
            this.barHealth.GradientColor2 = System.Drawing.Color.Lime;
            this.barHealth.Location = new System.Drawing.Point(644, 340);
            this.barHealth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barHealth.Name = "barHealth";
            this.barHealth.Size = new System.Drawing.Size(150, 32);
            this.barHealth.TabIndex = 8;
            // 
            // barSleep
            // 
            this.barSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barSleep.GradientColor1 = System.Drawing.Color.Red;
            this.barSleep.GradientColor2 = System.Drawing.Color.Lime;
            this.barSleep.Location = new System.Drawing.Point(486, 340);
            this.barSleep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barSleep.Name = "barSleep";
            this.barSleep.Size = new System.Drawing.Size(150, 32);
            this.barSleep.TabIndex = 7;
            // 
            // barPurity
            // 
            this.barPurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barPurity.GradientColor1 = System.Drawing.Color.Red;
            this.barPurity.GradientColor2 = System.Drawing.Color.Lime;
            this.barPurity.Location = new System.Drawing.Point(328, 340);
            this.barPurity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barPurity.Name = "barPurity";
            this.barPurity.Size = new System.Drawing.Size(150, 32);
            this.barPurity.TabIndex = 6;
            // 
            // barMood
            // 
            this.barMood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barMood.GradientColor1 = System.Drawing.Color.Red;
            this.barMood.GradientColor2 = System.Drawing.Color.Lime;
            this.barMood.Location = new System.Drawing.Point(170, 340);
            this.barMood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barMood.Name = "barMood";
            this.barMood.Size = new System.Drawing.Size(150, 32);
            this.barMood.TabIndex = 5;
            // 
            // barFood
            // 
            this.barFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barFood.GradientColor1 = System.Drawing.Color.Red;
            this.barFood.GradientColor2 = System.Drawing.Color.Lime;
            this.barFood.Location = new System.Drawing.Point(12, 340);
            this.barFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barFood.Name = "barFood";
            this.barFood.Size = new System.Drawing.Size(150, 32);
            this.barFood.TabIndex = 2;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(810, 473);
            this.Controls.Add(this.panelMiniIcons);
            this.Controls.Add(this.labelXP);
            this.Controls.Add(this.labelMoneys);
            this.Controls.Add(this.barHealth);
            this.Controls.Add(this.barSleep);
            this.Controls.Add(this.barPurity);
            this.Controls.Add(this.barMood);
            this.Controls.Add(this.panelIcons);
            this.Controls.Add(this.barFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIcons;
        public PearXLib.Engine.XBar barFood;
        public PearXLib.Engine.XBar barMood;
        public PearXLib.Engine.XBar barPurity;
        public PearXLib.Engine.XBar barSleep;
        public PearXLib.Engine.XBar barHealth;
        public System.Windows.Forms.Timer timerMood;
        public System.Windows.Forms.Timer timerFood;
        public System.Windows.Forms.Timer timerSleep;
        public System.Windows.Forms.Timer timerPurity;
        public System.Windows.Forms.Label labelMoneys;
        public System.Windows.Forms.Label labelXP;
        private System.Windows.Forms.Panel panelMiniIcons;











    }
}