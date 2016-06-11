namespace pcs.MiniGames
{
    partial class MGHangman
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcsButton1 = new pcs.Components.Controls.PCSButton();
            this.SuspendLayout();
            // 
            // pcsButton1
            // 
            this.pcsButton1.Border = 0;
            this.pcsButton1.Location = new System.Drawing.Point(179, 134);
            this.pcsButton1.Name = "pcsButton1";
            this.pcsButton1.Size = new System.Drawing.Size(106, 142);
            this.pcsButton1.TabIndex = 0;
            this.pcsButton1.Text = "pcsButton1";
            // 
            // MGHangman
            // 
            this.Controls.Add(this.pcsButton1);
            this.Name = "MGHangman";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Controls.PCSButton pcsButton1;
    }
}
