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
    public partial class SaveManager : Form
    {
        public SaveManager()
        {
            InitializeComponent();
        }

        private void slot1Save_Click(object sender, EventArgs e)
        {
            a.Save("1.save");
        }

        private void slot1Load_Click(object sender, EventArgs e)
        {
            a.Load("1.save");
            a.Setup();
        }

        private void slot2Save_Click(object sender, EventArgs e)
        {
            a.Save("2.save");
        }

        private void slot2Load_Click(object sender, EventArgs e)
        {
            a.Load("2.save");
            a.Setup();
        }

        private void slot3Save_Click(object sender, EventArgs e)
        {
            a.Save("3.save");
        }

        private void slot3Load_Click(object sender, EventArgs e)
        {
            a.Load("3.save");
            a.Setup();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            a.Reset();
        }

        
    }
}
