namespace pcs
{
    partial class Chat
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
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.panelChat = new System.Windows.Forms.Panel();
            this.labelChat = new System.Windows.Forms.Label();
            this.panelChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxChat
            // 
            this.textBoxChat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChat.Location = new System.Drawing.Point(0, 116);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(376, 26);
            this.textBoxChat.TabIndex = 0;
            // 
            // panelChat
            // 
            this.panelChat.AutoScroll = true;
            this.panelChat.Controls.Add(this.labelChat);
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChat.Location = new System.Drawing.Point(0, 0);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(376, 116);
            this.panelChat.TabIndex = 1;
            // 
            // labelChat
            // 
            this.labelChat.AutoSize = true;
            this.labelChat.Location = new System.Drawing.Point(0, 0);
            this.labelChat.MaximumSize = new System.Drawing.Size(350, 0);
            this.labelChat.Name = "labelChat";
            this.labelChat.Size = new System.Drawing.Size(35, 13);
            this.labelChat.TabIndex = 0;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 142);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.textBoxChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Chat";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Chat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterCommand_KeyDown);
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Panel panelChat;
        public System.Windows.Forms.Label labelChat;
    }
}