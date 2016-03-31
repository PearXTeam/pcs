using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using pcs.Components;
using pcs.Forms;
using pcs.Properties;

namespace pcs.ToolIcons
{
    public class TISaveManager : SToolIcon
    {
        public static TISaveManager ins = new TISaveManager();

        public override Image GetIcon()
        {
            return PCSImages.Floppy;
        }

        public override void OnClick(object sender, EventArgs e)
        {
            SaveManager.instance.ShowDialog(Game.instance);
        }

        public override string Desc()
        {
            return PCS.Loc.GetString("title.savemanager");
        }
    }
}
