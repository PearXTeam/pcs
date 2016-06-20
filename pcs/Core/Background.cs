using pcs.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace pcs.Core
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
