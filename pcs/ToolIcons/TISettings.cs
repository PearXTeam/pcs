using pcs.Components;
using System;
using System.Drawing;
using pcs.Core;
using pcs.Forms;
using pcs.Init;

namespace pcs.ToolIcons
{
    public class TISettings : SToolIcon
    {
        public static TISettings ins = new TISettings();

        public override Image GetIcon()
        {
            return PCSImages.Settings;
        }

        public override void OnClick(object sender, EventArgs e)
        {
            Options.instance.ShowDialog(Game.instance);
        }

        public override string Desc()
        {
            return PCS.Loc.GetString("title.options");
        }
    }
}
