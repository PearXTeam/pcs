using System;
using System.Drawing;
using pcs.Components;
using pcs.Core;
using pcs.Forms;
using pcs.Init;

namespace pcs.Icons
{
    public class IconMiniGames : SIcon
    {
        public override Image GetIcon()
        {
            return PCSImages.Dice;
        }

        public override void OnClick(object sender, EventArgs e)
        {
            MiniGamesGUI.Instance.ShowDialog(Game.instance);
        }

        public override string GetName()
        {
            return PCS.Loc.GetString("title.minigames");
        }
    }
}
