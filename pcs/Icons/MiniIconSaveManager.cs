using pcs.Properties;
using pcs.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs.Icons
{
    public class MiniIconSaveManager : SMiniIcon
    {
        public Image Icon() { return Resources.Floppy; }
        public void OnClick(object sender, EventArgs e)
        {
            new SaveManager().ShowDialog((UserControl)sender);
        }
    }
}
