using pcs.Components;
using System;
using System.Drawing;
using pcs.Core;
using pcs.Forms;
using pcs.Init;

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
