namespace pcs
{
    partial class CatOrDog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatOrDog));
            this.imageCatOrDog = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageCatOrDog)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCatOrDog
            // 
            this.imageCatOrDog.Location = new System.Drawing.Point(0, 0);
            this.imageCatOrDog.Name = "imageCatOrDog";
            this.imageCatOrDog.Size = new System.Drawing.Size(327, 235);
            this.imageCatOrDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageCatOrDog.TabIndex = 0;
            this.imageCatOrDog.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 238);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 13);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Очки: ";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Location = new System.Drawing.Point(12, 253);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(50, 13);
            this.labelRecord.TabIndex = 2;
            this.labelRecord.Text = "Рекорд: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Стрелка влево = кот.\r\nСтрелка вправо = собака.";
            // 
            // CatOrDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.imageCatOrDog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CatOrDog";
            this.Text = "Кот или собака?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatOrDog_FormClosing);
            this.Load += new System.EventHandler(this.CatOrDog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatOrDog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageCatOrDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageCatOrDog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Label label1;
    }
}