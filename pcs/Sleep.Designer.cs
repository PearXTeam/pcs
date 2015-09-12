namespace pcs
{
    partial class Sleep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sleep));
            this.imageSleep2h = new System.Windows.Forms.PictureBox();
            this.labelSleep2hDesc = new System.Windows.Forms.Label();
            this.imageSleep4h = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageSleep6h = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageSleep2h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSleep4h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSleep6h)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSleep2h
            // 
            this.imageSleep2h.BackColor = System.Drawing.Color.Transparent;
            this.imageSleep2h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSleep2h.Image = global::pcs.Properties.Resources.sleep2h;
            this.imageSleep2h.Location = new System.Drawing.Point(12, 12);
            this.imageSleep2h.Name = "imageSleep2h";
            this.imageSleep2h.Size = new System.Drawing.Size(90, 90);
            this.imageSleep2h.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSleep2h.TabIndex = 21;
            this.imageSleep2h.TabStop = false;
            this.imageSleep2h.Click += new System.EventHandler(this.imageSleep2h_Click);
            // 
            // labelSleep2hDesc
            // 
            this.labelSleep2hDesc.AutoSize = true;
            this.labelSleep2hDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSleep2hDesc.ForeColor = System.Drawing.Color.Blue;
            this.labelSleep2hDesc.Location = new System.Drawing.Point(29, 105);
            this.labelSleep2hDesc.Name = "labelSleep2hDesc";
            this.labelSleep2hDesc.Size = new System.Drawing.Size(60, 32);
            this.labelSleep2hDesc.TabIndex = 22;
            this.labelSleep2hDesc.Text = "-2 голод\r\n+2 cон";
            // 
            // imageSleep4h
            // 
            this.imageSleep4h.BackColor = System.Drawing.Color.Transparent;
            this.imageSleep4h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSleep4h.Image = global::pcs.Properties.Resources.sleep4h;
            this.imageSleep4h.Location = new System.Drawing.Point(132, 12);
            this.imageSleep4h.Name = "imageSleep4h";
            this.imageSleep4h.Size = new System.Drawing.Size(90, 90);
            this.imageSleep4h.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSleep4h.TabIndex = 23;
            this.imageSleep4h.TabStop = false;
            this.imageSleep4h.Click += new System.EventHandler(this.imageSleep4h_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(149, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "-4 голод\r\n+4 сон";
            // 
            // imageSleep6h
            // 
            this.imageSleep6h.BackColor = System.Drawing.Color.Transparent;
            this.imageSleep6h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSleep6h.Image = global::pcs.Properties.Resources.sleep6h;
            this.imageSleep6h.Location = new System.Drawing.Point(247, 12);
            this.imageSleep6h.Name = "imageSleep6h";
            this.imageSleep6h.Size = new System.Drawing.Size(90, 90);
            this.imageSleep6h.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSleep6h.TabIndex = 25;
            this.imageSleep6h.TabStop = false;
            this.imageSleep6h.Click += new System.EventHandler(this.imageSleep6h_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(261, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "-6 голод\r\n+6 сон";
            // 
            // Sleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageSleep6h);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageSleep4h);
            this.Controls.Add(this.labelSleep2hDesc);
            this.Controls.Add(this.imageSleep2h);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sleep";
            this.Text = "Сон";
            ((System.ComponentModel.ISupportInitialize)(this.imageSleep2h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSleep4h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSleep6h)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageSleep2h;
        private System.Windows.Forms.Label labelSleep2hDesc;
        private System.Windows.Forms.PictureBox imageSleep4h;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imageSleep6h;
        private System.Windows.Forms.Label label2;
    }
}