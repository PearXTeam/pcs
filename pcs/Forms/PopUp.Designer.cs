namespace pcs.Forms
{
    partial class PopUp
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
            this.lblMsg = new pcs.Components.PCSLabel();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.DrawInRectangle = true;
            this.lblMsg.Font = new System.Drawing.Font("Yanone Kaffeesatz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMsg.Location = new System.Drawing.Point(12, 38);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(258, 139);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "msg";
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 189);
            this.Controls.Add(this.lblMsg);
            this.Name = "PopUp";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.PCSLabel lblMsg;
    }
}