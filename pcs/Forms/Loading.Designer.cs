﻿namespace pcs.Forms
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
            this.bar2 = new PearXLib.Engine.Flat.FlatBar();
            this.bar1 = new PearXLib.Engine.Flat.FlatBar();
            this.lbl1 = new pcs.Components.PCSLabel();
            this.lbl2 = new pcs.Components.PCSLabel();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.bar2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bar2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bar2.Location = new System.Drawing.Point(12, 448);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(744, 52);
            this.bar2.TabIndex = 0;
            // 
            // bar1
            // 
            this.bar1.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.bar1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bar1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bar1.Location = new System.Drawing.Point(12, 364);
            this.bar1.Maximum = 2;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(744, 52);
            this.bar1.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(343, 335);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(82, 26);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Loading ... ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(343, 419);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(70, 26);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Initing ...";
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
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.bar2);
            this.Name = "Loading";
            this.Text = "Loading";
            this.Shown += new System.EventHandler(this.Loading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PearXLib.Engine.Flat.FlatBar bar2;
        private PearXLib.Engine.Flat.FlatBar bar1;
        private Components.PCSLabel lbl1;
        private Components.PCSLabel lbl2;
        private System.Windows.Forms.PictureBox logo;
    }
}