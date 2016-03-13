using pcs.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace pcs
{
    public class Background : Form
    {
        public static Background instance = new Background();

        public Background()
        {
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(31, 33, 36);
            WindowState = FormWindowState.Maximized;
            Loading.instance.Show(this);
        }
    }
}
