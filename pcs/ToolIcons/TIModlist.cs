using pcs.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using pcs.Properties;
using pcs.Forms;

namespace pcs.ToolIcons
{
    public class TIModlist : SToolIcon
    {
        public static TIModlist ins = new TIModlist();

        public override Image GetIcon()
        {
            return PCSImages.Puzzle;
        }

        public override void OnClick(object sender, EventArgs e)
        {
            Modlist.instance.ShowDialog(Game.instance);
        }

        public override string Desc()
        {
            return PCS.Loc.GetString("title.modlist");
        }
    }
}
