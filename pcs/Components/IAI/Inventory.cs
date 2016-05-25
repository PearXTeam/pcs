using System;
using System.Collections;
using System.Collections.Generic;

namespace pcs.Components.IAI
{
    public class Inventory : List<ItemStack>
    {
        public new void Add(ItemStack itm)
        {
            base.Add(itm);
        }
    }
}
