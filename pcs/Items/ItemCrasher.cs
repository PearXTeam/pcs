using System.Windows.Forms;
using pcs.Core;
using pcs.IAI;
using pcs.Init;

namespace pcs.Items
{
    public class ItemCrasher : Item
    {
        public ItemCrasher()
        {
            SetID("PCS:Crasher");
            SetName(PCS.Loc.GetString("item.crasher"));
            SetAvailableInShop(false);
            SetIcon(PCSImages.Crasher);
            SetTooltip(PCS.Loc.GetString("item.crasher.tip"));
        }

        public override void OnUse(object sender, MouseButtons b, ref ItemStack stack)
        {
            base.OnUse(sender, b, ref stack);
            Crash.PerformCrash("Crashed by Crasher! MUAHAHAHA!!");
        }
    }
}
