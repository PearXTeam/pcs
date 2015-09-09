using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void buttonSite_Click(object sender, EventArgs e)
        {
            Process.Start("http://pearx.ru/");
        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("http://github.com/mrAppleXZ");
        }

        private void buttonVK_Click(object sender, EventArgs e)
        {
            Process.Start("http://vk.com/pearx");
        }

        private void buttonYT_Click(object sender, EventArgs e)
        {
            Process.Start("http://youtube.com/PearXOfficial");
        }
    }
}
