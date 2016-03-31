using System;
using System.Drawing;
using pcs.Components;
using pcs.Forms;
using pcs.Properties;

namespace pcs.ToolIcons
{
    public class TIAbout : SToolIcon
    {
        public static TIAbout ins = new TIAbout();

        public override Image GetIcon()
        {
            return PCSImages.About;
        }

        public override string Desc()
        {
            return PCS.Loc.GetString("title.about");
        }

        public override void OnClick(object sender, EventArgs e)
        {
            About.instance.ShowDialog(Game.instance);
        }
    }
}
