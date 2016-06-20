using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pcs.Components.IAI;
using pcs.Core;
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
