namespace pcs
{
    partial class MiniGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniGames));
            this.imageCatchCat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageCatOrDog = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageCatchCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCatOrDog)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCatchCat
            // 
            this.imageCatchCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageCatchCat.Image = global::pcs.Properties.Resources.cat;
            this.imageCatchCat.Location = new System.Drawing.Point(12, 12);
            this.imageCatchCat.Name = "imageCatchCat";
            this.imageCatchCat.Size = new System.Drawing.Size(90, 90);
            this.imageCatchCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageCatchCat.TabIndex = 0;
            this.imageCatchCat.TabStop = false;
            this.imageCatchCat.Click += new System.EventHandler(this.imageCatchCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поймай кота";
            // 
            // imageCatOrDog
            // 
            this.imageCatOrDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageCatOrDog.Image = global::pcs.Properties.Resources.dog;
            this.imageCatOrDog.Location = new System.Drawing.Point(107, 12);
            this.imageCatOrDog.Name = "imageCatOrDog";
            this.imageCatOrDog.Size = new System.Drawing.Size(90, 90);
            this.imageCatOrDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageCatOrDog.TabIndex = 2;
            this.imageCatOrDog.TabStop = false;
            this.imageCatOrDog.Click += new System.EventHandler(this.imageCatOrDog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кот или собака?";
            // 
            // MiniGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(446, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageCatOrDog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageCatchCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MiniGames";
            this.Text = "Мини-игры";
            ((System.ComponentModel.ISupportInitialize)(this.imageCatchCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCatOrDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageCatchCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imageCatOrDog;
        private System.Windows.Forms.Label label2;
    }
}