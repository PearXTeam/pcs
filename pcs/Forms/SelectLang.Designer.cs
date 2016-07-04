namespace pcs.Forms
{
    partial class SelectLang
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
            this.lbSelectLang = new PearXLib.Engine.ListBoxSelectLang();
            this.SuspendLayout();
            // 
            // lbSelectLang
            // 
            this.lbSelectLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.lbSelectLang.Font = new System.Drawing.Font("Yanone Kaffeesatz F", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSelectLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbSelectLang.FormattingEnabled = true;
            this.lbSelectLang.ItemHeight = 32;
            this.lbSelectLang.Location = new System.Drawing.Point(12, 40);
            this.lbSelectLang.Name = "lbSelectLang";
            this.lbSelectLang.PathToLangs = "";
            this.lbSelectLang.Size = new System.Drawing.Size(316, 260);
            this.lbSelectLang.TabIndex = 0;
            this.lbSelectLang.LanguageSelected += new PearXLib.Engine.ListBoxSelectLang.LangEventHandler(this.lbSelectLang_LanguageSelected);
            // 
            // SelectLang
            // 
            this.ClientSize = new System.Drawing.Size(340, 331);
            this.Controls.Add(this.lbSelectLang);
            this.Name = "SelectLang";
            this.Text = "Select your language";
            this.ResumeLayout(false);

        }

        #endregion

        private PearXLib.Engine.ListBoxSelectLang lbSelectLang;
    }
}