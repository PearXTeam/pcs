using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using pcs.Player;

namespace pcs.Components.IAI
{
    public class Item
    {
        /// <summary>
        /// A name of the Item
        /// </summary>
        public virtual string Name(ItemStack stack)
        {
            return "Undefined Item";
        }

        /// <summary>
        /// An ID of the Item
        /// </summary>
        public virtual string ID()
        {
            return "PCS_UndefinedItem";
        }

        /// <summary>
        /// The 64x64 item's icon
        /// </summary>
        public virtual Image Icon(ItemStack stack)
        {
            return PCSImages.MissingIcon;
        }

        /// <summary>
        /// The description of the item.
        /// </summary>
        /// <returns></returns>
        public virtual string Description(ItemStack stack)
        {
            return "";
        }

        /// <summary>
        /// Max stack size.
        /// </summary>
        public virtual long MaxStackSize(ItemStack stack)
        {
            return 128;
        }


        //SHOP \/

        /// <summary>
        /// An Item's price in the Shop
        /// </summary>
        public virtual long ShopPrice(ItemStack stack)
        {
            return 100;
        }

        /// <summary>
        /// Can player buy this item?
        /// </summary>
        public virtual bool CanBuy(ItemStack stack)
        {
            if (PlayerVals.Money >= ShopPrice(stack))
            {
                return true;
            }
            else
            {
                new PopUp().Display(PCS.Loc.GetString("shop.buy.notEnoughMoney.title"), PCS.Loc.GetString("shop.buy.notEnoughMoney"));
                return false;
            }
        }

        /// <summary>
        /// Performs on Item.Buy();
        /// </summary>
        /// <param name="stack"></param>
        public virtual void OnBuy(ref ItemStack stack) { }

        /// <summary>
        /// Buy this Item
        /// </summary>
        /// <param name="stack">Bought ItemStack</param>
        public static void Buy(ref ItemStack stack)
        {
            stack.Item.OnBuy(ref stack);
            PlayerVals.Money -= stack.Item.ShopPrice(stack);
            PlayerInventory.Inventory.Add(stack);
        }

        //Events:
        /// <summary>
        /// Performs on player clicked this item in his inventory.
        /// </summary>
        /// <param name="b">Mouse Button</param>
        /// <param name="stack">Clicked ItemStack</param>
        public virtual void OnUse(MouseButtons b, ref ItemStack stack)
        {
            
        }

        /// <summary>
        /// Returns all available SubIDs.
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetSubIDs()
        {
            return new List<string>();
        }
    }
}
