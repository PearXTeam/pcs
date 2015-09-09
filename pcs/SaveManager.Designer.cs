namespace pcs
{
    partial class SaveManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveManager));
            this.label1 = new System.Windows.Forms.Label();
            this.slot1Save = new System.Windows.Forms.Button();
            this.slot1Load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.slot2Save = new System.Windows.Forms.Button();
            this.slot2Load = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.slot3Save = new System.Windows.Forms.Button();
            this.slot3Load = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Слот 1:";
            // 
            // slot1Save
            // 
            this.slot1Save.Location = new System.Drawing.Point(12, 25);
            this.slot1Save.Name = "slot1Save";
            this.slot1Save.Size = new System.Drawing.Size(75, 23);
            this.slot1Save.TabIndex = 1;
            this.slot1Save.Text = "Сохранить";
            this.slot1Save.UseVisualStyleBackColor = true;
            this.slot1Save.Click += new System.EventHandler(this.slot1Save_Click);
            // 
            // slot1Load
            // 
            this.slot1Load.Location = new System.Drawing.Point(93, 25);
            this.slot1Load.Name = "slot1Load";
            this.slot1Load.Size = new System.Drawing.Size(75, 23);
            this.slot1Load.TabIndex = 2;
            this.slot1Load.Text = "Загрузить";
            this.slot1Load.UseVisualStyleBackColor = true;
            this.slot1Load.Click += new System.EventHandler(this.slot1Load_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слот 2:";
            // 
            // slot2Save
            // 
            this.slot2Save.Location = new System.Drawing.Point(12, 67);
            this.slot2Save.Name = "slot2Save";
            this.slot2Save.Size = new System.Drawing.Size(75, 23);
            this.slot2Save.TabIndex = 4;
            this.slot2Save.Text = "Сохранить";
            this.slot2Save.UseVisualStyleBackColor = true;
            this.slot2Save.Click += new System.EventHandler(this.slot2Save_Click);
            // 
            // slot2Load
            // 
            this.slot2Load.Location = new System.Drawing.Point(93, 67);
            this.slot2Load.Name = "slot2Load";
            this.slot2Load.Size = new System.Drawing.Size(75, 23);
            this.slot2Load.TabIndex = 5;
            this.slot2Load.Text = "Загрузить";
            this.slot2Load.UseVisualStyleBackColor = true;
            this.slot2Load.Click += new System.EventHandler(this.slot2Load_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Слот 3:";
            // 
            // slot3Save
            // 
            this.slot3Save.Location = new System.Drawing.Point(12, 109);
            this.slot3Save.Name = "slot3Save";
            this.slot3Save.Size = new System.Drawing.Size(75, 23);
            this.slot3Save.TabIndex = 7;
            this.slot3Save.Text = "Сохранить";
            this.slot3Save.UseVisualStyleBackColor = true;
            this.slot3Save.Click += new System.EventHandler(this.slot3Save_Click);
            // 
            // slot3Load
            // 
            this.slot3Load.Location = new System.Drawing.Point(93, 109);
            this.slot3Load.Name = "slot3Load";
            this.slot3Load.Size = new System.Drawing.Size(75, 23);
            this.slot3Load.TabIndex = 8;
            this.slot3Load.Text = "Загрузить";
            this.slot3Load.UseVisualStyleBackColor = true;
            this.slot3Load.Click += new System.EventHandler(this.slot3Load_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(197, 25);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 107);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // SaveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.slot3Load);
            this.Controls.Add(this.slot3Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slot2Load);
            this.Controls.Add(this.slot2Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slot1Load);
            this.Controls.Add(this.slot1Save);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaveManager";
            this.Text = "Менеджер сохранений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button slot1Save;
        private System.Windows.Forms.Button slot1Load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button slot2Save;
        private System.Windows.Forms.Button slot2Load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button slot3Save;
        private System.Windows.Forms.Button slot3Load;
        private System.Windows.Forms.Button buttonReset;
    }
}