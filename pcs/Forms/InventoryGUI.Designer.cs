namespace pcs.Forms
{
    partial class InventoryGUI
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
            this.playerInventory = new pcs.IAI.InventoryGUIContainer();
            this.SuspendLayout();
            // 
            // playerInventory
            // 
            this.playerInventory.Location = new System.Drawing.Point(12, 38);
            this.playerInventory.Name = "playerInventory";
            this.playerInventory.Size = new System.Drawing.Size(540, 380);
            this.playerInventory.TabIndex = 0;
            // 
            // InventoryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 430);
            this.Controls.Add(this.playerInventory);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "InventoryGUI";
            this.Text = "InventoryGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private IAI.InventoryGUIContainer playerInventory;
    }
}