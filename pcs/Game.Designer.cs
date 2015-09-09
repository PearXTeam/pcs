namespace pcs
{
    partial class Game
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.autoSave = new System.Windows.Forms.Timer(this.components);
            this.barHealth = new System.Windows.Forms.ProgressBar();
            this.barFun = new System.Windows.Forms.ProgressBar();
            this.barFood = new System.Windows.Forms.ProgressBar();
            this.barSleep = new System.Windows.Forms.ProgressBar();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelFun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelSleep = new System.Windows.Forms.Label();
            this.timerFood = new System.Windows.Forms.Timer(this.components);
            this.timerFun = new System.Windows.Forms.Timer(this.components);
            this.timerSleep = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // autoSave
            // 
            this.autoSave.Enabled = true;
            this.autoSave.Interval = 120000;
            this.autoSave.Tick += new System.EventHandler(this.autoSave_Tick);
            // 
            // barHealth
            // 
            this.barHealth.Location = new System.Drawing.Point(456, 385);
            this.barHealth.Name = "barHealth";
            this.barHealth.Size = new System.Drawing.Size(100, 23);
            this.barHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHealth.TabIndex = 0;
            // 
            // barFun
            // 
            this.barFun.Location = new System.Drawing.Point(562, 385);
            this.barFun.Name = "barFun";
            this.barFun.Size = new System.Drawing.Size(100, 23);
            this.barFun.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barFun.TabIndex = 1;
            // 
            // barFood
            // 
            this.barFood.Location = new System.Drawing.Point(668, 385);
            this.barFood.Name = "barFood";
            this.barFood.Size = new System.Drawing.Size(100, 23);
            this.barFood.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barFood.TabIndex = 2;
            // 
            // barSleep
            // 
            this.barSleep.Location = new System.Drawing.Point(774, 385);
            this.barSleep.Name = "barSleep";
            this.barSleep.Size = new System.Drawing.Size(100, 23);
            this.barSleep.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barSleep.TabIndex = 3;
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelHealth.ForeColor = System.Drawing.Color.Orange;
            this.labelHealth.Location = new System.Drawing.Point(453, 367);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(35, 13);
            this.labelHealth.TabIndex = 5;
            this.labelHealth.Text = "label1";
            // 
            // labelFun
            // 
            this.labelFun.AutoSize = true;
            this.labelFun.BackColor = System.Drawing.Color.Transparent;
            this.labelFun.ForeColor = System.Drawing.Color.Orange;
            this.labelFun.Location = new System.Drawing.Point(559, 367);
            this.labelFun.Name = "labelFun";
            this.labelFun.Size = new System.Drawing.Size(35, 13);
            this.labelFun.TabIndex = 6;
            this.labelFun.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-5, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(895, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "_________________________________________________________________________________" +
    "___________________________________________________________________";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.BackColor = System.Drawing.Color.Transparent;
            this.labelFood.ForeColor = System.Drawing.Color.Orange;
            this.labelFood.Location = new System.Drawing.Point(665, 367);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(35, 13);
            this.labelFood.TabIndex = 8;
            this.labelFood.Text = "label2";
            // 
            // labelSleep
            // 
            this.labelSleep.AutoSize = true;
            this.labelSleep.BackColor = System.Drawing.Color.Transparent;
            this.labelSleep.ForeColor = System.Drawing.Color.Orange;
            this.labelSleep.Location = new System.Drawing.Point(771, 367);
            this.labelSleep.Name = "labelSleep";
            this.labelSleep.Size = new System.Drawing.Size(35, 13);
            this.labelSleep.TabIndex = 9;
            this.labelSleep.Text = "label2";
            // 
            // timerFood
            // 
            this.timerFood.Enabled = true;
            this.timerFood.Interval = 35000;
            this.timerFood.Tick += new System.EventHandler(this.timerFood_Tick);
            // 
            // timerFun
            // 
            this.timerFun.Enabled = true;
            this.timerFun.Interval = 105000;
            this.timerFun.Tick += new System.EventHandler(this.timerFun_Tick);
            // 
            // timerSleep
            // 
            this.timerSleep.Enabled = true;
            this.timerSleep.Interval = 40000;
            this.timerSleep.Tick += new System.EventHandler(this.timerSleep_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(886, 420);
            this.Controls.Add(this.labelSleep);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFun);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.barSleep);
            this.Controls.Add(this.barFood);
            this.Controls.Add(this.barFun);
            this.Controls.Add(this.barHealth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Game";
            this.Text = "PCS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer autoSave;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelHealth;
        public System.Windows.Forms.Label labelFun;
        public System.Windows.Forms.Label labelFood;
        public System.Windows.Forms.Label labelSleep;
        public System.Windows.Forms.Timer timerFood;
        public System.Windows.Forms.Timer timerFun;
        public System.Windows.Forms.Timer timerSleep;
        public System.Windows.Forms.ProgressBar barHealth;
        public System.Windows.Forms.ProgressBar barFun;
        public System.Windows.Forms.ProgressBar barFood;
        public System.Windows.Forms.ProgressBar barSleep;
    }
}

