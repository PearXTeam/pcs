namespace pcs.Forms
{
    partial class PCSInputForm
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
            this.tbIn = new System.Windows.Forms.TextBox();
            this.buttonOK = new PearXLib.Engine.Flat.FlatButton();
            this.SuspendLayout();
            // 
            // tbIn
            // 
            this.tbIn.Font = new System.Drawing.Font("Yanone Kaffeesatz", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIn.Location = new System.Drawing.Point(12, 41);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(362, 46);
            this.tbIn.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Border = 0;
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOK.Location = new System.Drawing.Point(12, 93);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(362, 64);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // PCSInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 168);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tbIn);
            this.Name = "PCSInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIn;
        private PearXLib.Engine.Flat.FlatButton buttonOK;
    }
}