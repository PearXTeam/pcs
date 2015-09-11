namespace pcs
{
    partial class CatchCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchCat));
            this.imageCat = new System.Windows.Forms.PictureBox();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageCat)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCat
            // 
            this.imageCat.Image = global::pcs.Properties.Resources.cat;
            this.imageCat.Location = new System.Drawing.Point(612, 39);
            this.imageCat.Name = "imageCat";
            this.imageCat.Size = new System.Drawing.Size(132, 132);
            this.imageCat.TabIndex = 0;
            this.imageCat.TabStop = false;
            this.imageCat.Click += new System.EventHandler(this.imageCat_Click);
            // 
            // timerMove
            // 
            this.timerMove.Enabled = true;
            this.timerMove.Interval = 450;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(44, 13);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Очки: 0";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Location = new System.Drawing.Point(12, 22);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(35, 13);
            this.labelRecord.TabIndex = 2;
            this.labelRecord.Text = "label1";
            // 
            // CatchCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 460);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.imageCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CatchCat";
            this.Text = "Поймай кота!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatchCat_FormClosing);
            this.Load += new System.EventHandler(this.CatchCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageCat;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelRecord;
    }
}