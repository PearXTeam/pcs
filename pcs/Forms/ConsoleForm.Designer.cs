namespace pcs.Forms
{
    partial class ConsoleForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.boxCommand = new System.Windows.Forms.TextBox();
            this.lblText = new pcs.Components.Controls.PCSLabel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.lblText);
            this.panel.Location = new System.Drawing.Point(5, 39);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(423, 161);
            this.panel.TabIndex = 1;
            // 
            // boxCommand
            // 
            this.boxCommand.Font = new System.Drawing.Font("Yanone Kaffeesatz F", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxCommand.Location = new System.Drawing.Point(5, 206);
            this.boxCommand.Name = "boxCommand";
            this.boxCommand.Size = new System.Drawing.Size(423, 33);
            this.boxCommand.TabIndex = 0;
            this.boxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxCommand_KeyDown);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.DrawInRectangle = true;
            this.lblText.Font = new System.Drawing.Font("Yanone Kaffeesatz F", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(3, 3);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(420, 158);
            this.lblText.TabIndex = 0;
            this.lblText.Text = null;
            // 
            // ConsoleForm
            // 
            this.CanMove = false;
            this.ClientSize = new System.Drawing.Size(433, 245);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.boxCommand);
            this.Name = "ConsoleForm";
            this.PanelBG = System.Drawing.Color.Transparent;
            this.Shown += new System.EventHandler(this.ConsoleForm_Shown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxCommand;
        public Components.Controls.PCSLabel lblText;
        public System.Windows.Forms.Panel panel;
    }
}