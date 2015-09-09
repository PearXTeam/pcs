namespace pcs
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.checkDebug = new System.Windows.Forms.CheckBox();
            this.checkPlug = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.checkAutosave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkDebug
            // 
            this.checkDebug.AutoSize = true;
            this.checkDebug.Location = new System.Drawing.Point(12, 12);
            this.checkDebug.Name = "checkDebug";
            this.checkDebug.Size = new System.Drawing.Size(69, 17);
            this.checkDebug.TabIndex = 0;
            this.checkDebug.Text = "Отладка";
            this.checkDebug.UseVisualStyleBackColor = true;
            this.checkDebug.CheckedChanged += new System.EventHandler(this.checkDebug_CheckedChanged);
            // 
            // checkPlug
            // 
            this.checkPlug.AutoSize = true;
            this.checkPlug.Location = new System.Drawing.Point(12, 35);
            this.checkPlug.Name = "checkPlug";
            this.checkPlug.Size = new System.Drawing.Size(75, 17);
            this.checkPlug.TabIndex = 1;
            this.checkPlug.Text = "Заглушка";
            this.checkPlug.UseVisualStyleBackColor = true;
            this.checkPlug.CheckedChanged += new System.EventHandler(this.checkPlug_CheckedChanged);
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(12, 58);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(130, 23);
            this.buttonSelectColor.TabIndex = 2;
            this.buttonSelectColor.Text = "Выбрать цвет обоев";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(148, 50);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(31, 37);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "•";
            // 
            // checkAutosave
            // 
            this.checkAutosave.AutoSize = true;
            this.checkAutosave.Location = new System.Drawing.Point(12, 87);
            this.checkAutosave.Name = "checkAutosave";
            this.checkAutosave.Size = new System.Drawing.Size(109, 17);
            this.checkAutosave.TabIndex = 4;
            this.checkAutosave.Text = "Автосохранение";
            this.checkAutosave.UseVisualStyleBackColor = true;
            this.checkAutosave.CheckedChanged += new System.EventHandler(this.checkAutosave_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 262);
            this.Controls.Add(this.checkAutosave);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.checkPlug);
            this.Controls.Add(this.checkDebug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkDebug;
        private System.Windows.Forms.CheckBox checkPlug;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.CheckBox checkAutosave;
    }
}