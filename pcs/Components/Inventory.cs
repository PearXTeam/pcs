using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs.Components
{
    public class Inventory : List<Item>
    {
        public new void Add(Item itm)
        {
            base.Add(itm);
        }
    }
}
