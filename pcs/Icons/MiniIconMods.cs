using pcs.Properties;
using pcs.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pcs.Icons
{
    class MiniIconMods : SMiniIcon
    {
        public Image Icon() { return Resources.Puzzle; }
        public void OnClick(object sender, EventArgs e)
        {
            
        }
    }
}
