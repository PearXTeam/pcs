using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pcs.IAI;

namespace pcs.Items
{ 
    public class ItemDebug : Item
    {
        public ItemDebug()
        {
            SetName("Debugging Item");
            SetAvailableInShop(false);
            SetID("PCS:Debug");
        }

        public override void OnUse(MouseButtons b, ref ItemStack stack)
        {
            stack.StackCount--;
        }
    }
}
