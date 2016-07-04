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

        //Food \/
        public static Item Apple = new ItemFood(new FoodItemArgs {Name = PCS.Loc.GetString("item.apple"), ID = "PCS:Apple", Icon = PCSImages.Apple, ShopPrice = 35, RestoreFood = 7});
        public static Item Coffee = new ItemFood(new FoodItemArgs {Name = PCS.Loc.GetString("item.coffee"), ID = "PCS:Coffee", Icon = PCSImages.Coffee, ShopPrice = 50, RestoreSleep = 8});
    }
}
