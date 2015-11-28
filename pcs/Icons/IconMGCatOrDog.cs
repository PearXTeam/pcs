using pcs.MiniGames;
using pcs.Properties;
using pcs.Types;
using PearXLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pcs.Icons
{
    public class IconMGCatOrDog : SIcon
    {
        public string Name() { return v.l.GetString("title.catOrDog"); }
        public Image Icon() { return Resources.CatOrDog; }
        public void OnClick(object sender, EventArgs e)
        {
            new CatOrDog().Show(((UserControl)sender).ParentForm);
        }
    }
}
