using pcs.Args;
using pcs.IAI;
using pcs.Core;
using pcs.Items;

namespace pcs.Init
{
    public class PCSItems
    {
        public static Item Sand = new Item(new ItemArgs {Name = PCS.Loc.GetString("item.sand"), ID = "PCS:Sand", Icon = PCSImages.Sand, Tooltip = PCS.Loc.GetString("item.sand.tip"), ShopPrice = 15});
        public static Item Crasher = new ItemCrasher();
        public static Item Debug = new ItemDebug();
    }
}
