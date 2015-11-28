using pcs.Properties;
using pcs.Types;
using PearXLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pcs.Icons
{
    class IconMiniGames : SIcon
    {
        public string Name() { return v.l.GetString("title.miniGames"); }
        public Image Icon() { return Resources.Dice; }
        public void OnClick(object sender, EventArgs e)
        {
            new MiniGamesGui().Show(((UserControl)sender).ParentForm);
        }
    }
}
