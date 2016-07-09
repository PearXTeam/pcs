namespace pcs.Forms
{
    partial class Loading
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl2 = new pcs.Components.Controls.PCSLabel();
            this.lbl1 = new pcs.Components.Controls.PCSLabel();
            this.bar1 = new pcs.Components.Controls.PCSBar();
            this.bar2 = new pcs.Components.Controls.PCSBar();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::pcs.Properties.Resources.PCSLogo;
            this.logo.Location = new System.Drawing.Point(128, 41);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(512, 256);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(353, 414);
            this.lbl2.MaximumSize = new System.Drawing.Size(62, 28);
            this.lbl2.MinimumSize = new System.Drawing.Size(62, 28);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(62, 28);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Initing...";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(356, 330);
            this.lbl1.MaximumSize = new System.Drawing.Size(59, 28);
            this.lbl1.MinimumSize = new System.Drawing.Size(59, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 28);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Loading";
            // 
            // bar1
            // 
            this.bar1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bar1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bar1.Location = new System.Drawing.Point(12, 364);
            this.bar1.Maximum = 2;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(744, 52);
            this.bar1.TabIndex = 1;
            // 
            // bar2
            // 
            this.bar2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bar2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bar2.Location = new System.Drawing.Point(12, 448);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(744, 52);
            this.bar2.TabIndex = 0;
            // 
            // Loading
            // 
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.bar2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Loading";
            this.Text = "Loading";
            this.Shown += new System.EventHandler(this.Loading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pcs.Components.Controls.PCSBar bar2;
        private pcs.Components.Controls.PCSBar bar1;
        private Components.Controls.PCSLabel lbl1;
        private Components.Controls.PCSLabel lbl2;
        private System.Windows.Forms.PictureBox logo;
    }
}