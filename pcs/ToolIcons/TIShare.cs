using pcs.Components;
using System;
using System.Drawing;
using pcs.Core;
using pcs.Forms;
using pcs.Init;

namespace pcs.ToolIcons
{
    public class TIShare : SToolIcon
    {
        public static TIShare ins = new TIShare();

        public override Image GetIcon()
        {
            return PCSImages.Share;
        }

        public override void OnClick(object sender, EventArgs e)
        {
            Share.instance.ShowDialog(Game.instance);
        }

        public override string Desc()
        {
            return PCS.Loc.GetString("title.share");
        }
    }
}
