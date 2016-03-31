using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using pcs.Components;
using pcs.Forms;

namespace pcs.ToolIcons
{
    public class TIAchievements : SToolIcon
    {
        public static TIAchievements ins = new TIAchievements();

        public override Image GetIcon()
        {
            return PCSImages.Trophy;
        }

        public override string Desc()
        {
            return PCS.Loc.GetString("title.achievements");
        }

        public override void OnClick(object sender, EventArgs e)
        {
            AchievementList.instance.ShowDialog(Game.instance);
        }
    }
}
