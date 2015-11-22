using pcs.Properties;
using pcs.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pcs.Icons
{
    class IconMiniGames : SIcon
    {
        public string Name() { return v.l.GetString("icon.minigames"); }
        public Image Icon() { return Resources.Dice; }
        public void OnClick(object sender, EventArgs e)
        {
            
        }
    }
}
