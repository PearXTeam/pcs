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
        }

        public override void OnUse(MouseButtons b, ref ItemStack stack)
        {
            Crash.PerformCrash("Crashed by crasher! MUAHAHA!");
        }
    }
}
