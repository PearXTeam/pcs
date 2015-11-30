using pcs.Properties;
using pcs.Types;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pcs.Icons
{
    public class MiniIconSettings : SMiniIcon
    {
        public Image Icon() { return Resources.Settings; }
        public void OnClick(object sender, EventArgs e)
        {
            new Settings().ShowDialog((UserControl)sender);
        }
    }
}
