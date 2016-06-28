using System;
using System.Drawing;
using pcs.Components;
using pcs.Core;
using pcs.Forms;
using pcs.Init;

namespace pcs.Icons
{
    public class IconInventory : SIcon
    {
        public override Image GetIcon()
        {
            return PCSImages.Backpack;
        }

        public override void OnClick(object sender, EventArgs e)
        {
            if (!PlayerInventoryGUI.Instance.Visible)
            {
                PlayerInventoryGUI.Instance.Show(Game.instance);
            }
        }

        public override string GetName()
        {
            return PCS.Loc.GetString("title.inventory");
        }
    }
}
