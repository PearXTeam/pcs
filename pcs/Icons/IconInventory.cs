using System;
using System.Drawing;
using pcs.Components;
using pcs.Forms;

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
            if(!InventoryGUI.Instance.Visible)
                InventoryGUI.Instance.Show(Game.instance);
        }

        public override string GetName()
        {
            return PCS.Loc.GetString("title.inventory");
        }
    }
}
