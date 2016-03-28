using System;

namespace pcs.Forms
{
    public partial class PCSInputForm : PCSForm
    {
        public string Inputed { get; set; }

        public PCSInputForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Inputed = tbIn.Text;
            Close();
        }
    }
}
