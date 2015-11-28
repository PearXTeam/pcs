using pcs.Properties;
using pcs.Types;
using System;
using System.Drawing;

namespace pcs.Icons
{
    public class MiniIconMods : SMiniIcon
    {
        public Image Icon() { return Resources.Puzzle; }
        public void OnClick(object sender, EventArgs e)
        {
            new ModList().ShowDialog();
        }
    }
}
