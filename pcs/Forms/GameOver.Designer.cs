namespace pcs.Forms
{
    partial class GameOver
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
            this.lblKilledby = new pcs.Components.Controls.PCSLabel();
            this.lblGameover = new pcs.Components.Controls.PCSLabel();
            this.btnOK = new pcs.Components.Controls.PCSButton();
            this.SuspendLayout();
            // 
            // lblKilledby
            // 
            this.lblKilledby.AutoSize = true;
            this.lblKilledby.Font = new System.Drawing.Font("Yanone Kaffeesatz F", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKilledby.Location = new System.Drawing.Point(12, 114);
            this.lblKilledby.Name = "lblKilledby";
            this.lblKilledby.Size = new System.Drawing.Size(107, 42);
            this.lblKilledby.TabIndex = 0;
            this.lblKilledby.Text = "Killed by";
            // 
            // lblGameover
            // 
            this.lblGameover.AutoSize = true;
            this.lblGameover.Font = new System.Drawing.Font("Yanone Kaffeesatz F", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameover.Location = new System.Drawing.Point(103, 37);
            this.lblGameover.Name = "lblGameover";
            this.lblGameover.Size = new System.Drawing.Size(245, 77);
            this.lblGameover.TabIndex = 1;
            this.lblGameover.Text = "GAME OVER";
            // 
            // btnOK
            // 
            this.btnOK.Border = 0;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(12, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(438, 64);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // GameOver
            // 
            this.ClientSize = new System.Drawing.Size(462, 249);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblGameover);
            this.Controls.Add(this.lblKilledby);
            this.Name = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.Controls.PCSLabel lblKilledby;
        public Components.Controls.PCSLabel lblGameover;
        private pcs.Components.Controls.PCSButton btnOK;
    }
}