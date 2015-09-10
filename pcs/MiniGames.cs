using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    public partial class MiniGames : Form
    {
        public MiniGames()
        {
            InitializeComponent();
        }

        private void imageCatchCat_Click(object sender, EventArgs e)
        {
            CatchCat cc = new CatchCat();
            cc.Owner = Program.g;
            cc.Show();
            this.Close();
        }
    }
}
