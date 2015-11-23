namespace pcs
{
    partial class Death
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
            this.imageKilledBy = new System.Windows.Forms.PictureBox();
            this.buttonClose = new PearXLib.Engine.XButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageKilledBy)).BeginInit();
            this.SuspendLayout();
            // 
            // imageKilledBy
            // 
            this.imageKilledBy.Location = new System.Drawing.Point(54, 12);
            this.imageKilledBy.Name = "imageKilledBy";
            this.imageKilledBy.Size = new System.Drawing.Size(128, 128);
            this.imageKilledBy.TabIndex = 0;
            this.imageKilledBy.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.ColorPressed = System.Drawing.Color.Gold;
            this.buttonClose.GradientColor1 = System.Drawing.Color.DarkOrange;
            this.buttonClose.GradientColorFocused1 = System.Drawing.Color.Orange;
            this.buttonClose.Location = new System.Drawing.Point(54, 182);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(128, 64);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Death
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 258);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.imageKilledBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Death";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Death";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Death_FormClosing);
            this.Load += new System.EventHandler(this.Death_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageKilledBy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageKilledBy;
        private PearXLib.Engine.XButton buttonClose;
    }
}