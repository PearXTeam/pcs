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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
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
            this.imageSettings = new System.Windows.Forms.PictureBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelXP = new System.Windows.Forms.Label();
            this.imageSaveManager = new System.Windows.Forms.PictureBox();
            this.imageInfo = new System.Windows.Forms.PictureBox();
            this.imageVK = new System.Windows.Forms.PictureBox();
            this.imageMiniGames = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageInv = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageShop = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageSleep = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageUpdaterGUI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSaveManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMiniGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUpdaterGUI)).BeginInit();
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
            this.barHealth.Size = new System.Drawing.Size(100, 14);
            this.barHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHealth.TabIndex = 0;
            // 
            // barFun
            // 
            this.barFun.Location = new System.Drawing.Point(562, 385);
            this.barFun.Name = "barFun";
            this.barFun.Size = new System.Drawing.Size(100, 14);
            this.barFun.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barFun.TabIndex = 1;
            // 
            // barFood
            // 
            this.barFood.Location = new System.Drawing.Point(668, 385);
            this.barFood.Name = "barFood";
            this.barFood.Size = new System.Drawing.Size(100, 14);
            this.barFood.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barFood.TabIndex = 2;
            // 
            // barSleep
            // 
            this.barSleep.Location = new System.Drawing.Point(774, 385);
            this.barSleep.Name = "barSleep";
            this.barSleep.Size = new System.Drawing.Size(100, 14);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
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
            // imageSettings
            // 
            this.imageSettings.BackColor = System.Drawing.Color.Transparent;
            this.imageSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSettings.Image = global::pcs.Properties.Resources.settings;
            this.imageSettings.Location = new System.Drawing.Point(415, 367);
            this.imageSettings.Name = "imageSettings";
            this.imageSettings.Size = new System.Drawing.Size(32, 32);
            this.imageSettings.TabIndex = 10;
            this.imageSettings.TabStop = false;
            this.imageSettings.Click += new System.EventHandler(this.imageSettings_Click);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.ForeColor = System.Drawing.Color.Orange;
            this.labelMoney.Location = new System.Drawing.Point(66, 374);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(70, 25);
            this.labelMoney.TabIndex = 11;
            this.labelMoney.Text = "label1";
            // 
            // labelXP
            // 
            this.labelXP.AutoSize = true;
            this.labelXP.BackColor = System.Drawing.Color.Transparent;
            this.labelXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXP.ForeColor = System.Drawing.Color.Orange;
            this.labelXP.Location = new System.Drawing.Point(66, 403);
            this.labelXP.Name = "labelXP";
            this.labelXP.Size = new System.Drawing.Size(70, 25);
            this.labelXP.TabIndex = 12;
            this.labelXP.Text = "label1";
            // 
            // imageSaveManager
            // 
            this.imageSaveManager.BackColor = System.Drawing.Color.Transparent;
            this.imageSaveManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSaveManager.Image = global::pcs.Properties.Resources.save;
            this.imageSaveManager.Location = new System.Drawing.Point(415, 405);
            this.imageSaveManager.Name = "imageSaveManager";
            this.imageSaveManager.Size = new System.Drawing.Size(32, 32);
            this.imageSaveManager.TabIndex = 13;
            this.imageSaveManager.TabStop = false;
            this.imageSaveManager.Click += new System.EventHandler(this.imageSaveManager_Click);
            // 
            // imageInfo
            // 
            this.imageInfo.BackColor = System.Drawing.Color.Transparent;
            this.imageInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageInfo.Image = global::pcs.Properties.Resources.info;
            this.imageInfo.Location = new System.Drawing.Point(377, 367);
            this.imageInfo.Name = "imageInfo";
            this.imageInfo.Size = new System.Drawing.Size(32, 32);
            this.imageInfo.TabIndex = 14;
            this.imageInfo.TabStop = false;
            this.imageInfo.Click += new System.EventHandler(this.imageInfo_Click);
            // 
            // imageVK
            // 
            this.imageVK.BackColor = System.Drawing.Color.Transparent;
            this.imageVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageVK.Image = global::pcs.Properties.Resources.vkontakte;
            this.imageVK.Location = new System.Drawing.Point(12, 380);
            this.imageVK.Name = "imageVK";
            this.imageVK.Size = new System.Drawing.Size(48, 48);
            this.imageVK.TabIndex = 15;
            this.imageVK.TabStop = false;
            this.imageVK.Click += new System.EventHandler(this.imageVK_Click);
            // 
            // imageMiniGames
            // 
            this.imageMiniGames.BackColor = System.Drawing.Color.Transparent;
            this.imageMiniGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageMiniGames.Image = global::pcs.Properties.Resources.game;
            this.imageMiniGames.Location = new System.Drawing.Point(774, 12);
            this.imageMiniGames.Name = "imageMiniGames";
            this.imageMiniGames.Size = new System.Drawing.Size(90, 90);
            this.imageMiniGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageMiniGames.TabIndex = 16;
            this.imageMiniGames.TabStop = false;
            this.imageMiniGames.Click += new System.EventHandler(this.imageMiniGames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(782, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Мини-игры";
            // 
            // imageInv
            // 
            this.imageInv.BackColor = System.Drawing.Color.Transparent;
            this.imageInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageInv.Image = global::pcs.Properties.Resources.packaging;
            this.imageInv.Location = new System.Drawing.Point(668, 12);
            this.imageInv.Name = "imageInv";
            this.imageInv.Size = new System.Drawing.Size(90, 90);
            this.imageInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageInv.TabIndex = 18;
            this.imageInv.TabStop = false;
            this.imageInv.Click += new System.EventHandler(this.imageInv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(675, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Инвентарь";
            // 
            // imageShop
            // 
            this.imageShop.BackColor = System.Drawing.Color.Transparent;
            this.imageShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageShop.Image = global::pcs.Properties.Resources.shop;
            this.imageShop.Location = new System.Drawing.Point(572, 12);
            this.imageShop.Name = "imageShop";
            this.imageShop.Size = new System.Drawing.Size(90, 90);
            this.imageShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageShop.TabIndex = 20;
            this.imageShop.TabStop = false;
            this.imageShop.Click += new System.EventHandler(this.imageShop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(584, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Магазин";
            // 
            // imageSleep
            // 
            this.imageSleep.BackColor = System.Drawing.Color.Transparent;
            this.imageSleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSleep.Image = global::pcs.Properties.Resources.sleep;
            this.imageSleep.Location = new System.Drawing.Point(476, 12);
            this.imageSleep.Name = "imageSleep";
            this.imageSleep.Size = new System.Drawing.Size(90, 90);
            this.imageSleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSleep.TabIndex = 22;
            this.imageSleep.TabStop = false;
            this.imageSleep.Click += new System.EventHandler(this.imageSleep_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(505, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Сон";
            // 
            // imageUpdaterGUI
            // 
            this.imageUpdaterGUI.BackColor = System.Drawing.Color.Transparent;
            this.imageUpdaterGUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageUpdaterGUI.Image = ((System.Drawing.Image)(resources.GetObject("imageUpdaterGUI.Image")));
            this.imageUpdaterGUI.Location = new System.Drawing.Point(377, 405);
            this.imageUpdaterGUI.Name = "imageUpdaterGUI";
            this.imageUpdaterGUI.Size = new System.Drawing.Size(32, 32);
            this.imageUpdaterGUI.TabIndex = 24;
            this.imageUpdaterGUI.TabStop = false;
            this.imageUpdaterGUI.Click += new System.EventHandler(this.imageUpdaterGUI_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 440);
            this.Controls.Add(this.imageUpdaterGUI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imageSleep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imageShop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imageInv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageMiniGames);
            this.Controls.Add(this.imageVK);
            this.Controls.Add(this.imageInfo);
            this.Controls.Add(this.imageSaveManager);
            this.Controls.Add(this.labelXP);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.imageSettings);
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
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "PCS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSaveManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMiniGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUpdaterGUI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox imageSettings;
        public System.Windows.Forms.Label labelMoney;
        public System.Windows.Forms.Label labelXP;
        private System.Windows.Forms.PictureBox imageSaveManager;
        private System.Windows.Forms.PictureBox imageInfo;
        private System.Windows.Forms.PictureBox imageVK;
        private System.Windows.Forms.PictureBox imageMiniGames;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer autoSave;
        private System.Windows.Forms.PictureBox imageInv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imageShop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imageSleep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox imageUpdaterGUI;
    }
}

