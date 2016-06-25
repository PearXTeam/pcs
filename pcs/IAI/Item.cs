using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using pcs.Components;
using pcs.Core;
using pcs.Player;

namespace pcs.IAI
{
    public class Item
    {
        private string _Name;
        private string _ID;
        private Image _Icon;
        private long _ShopPrice;
        private bool _AvailableInShop;

        public Item() { }
        public Item(string name, string id, Image icon, long shopPrice = 100, bool availableInShop = true)
        {
            _Name = name;
            _ID = id;
            _Icon = icon;
            _ShopPrice = shopPrice;
            _AvailableInShop = availableInShop;
        }
        /// <summary>
        /// A name of the Item
        /// </summary>
        public virtual string Name(ItemStack stack)
        {
            return _Name;
        }

        /// <summary>
        /// An ID of the Item
        /// </summary>
        public virtual string ID()
        {
            return _ID;
        }

        /// <summary>
        /// The 64x64 item's icon
        /// </summary>
        public virtual Image Icon(ItemStack stack)
        {
            return _Icon;
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

        public virtual bool AvailableInShop()
        {
            return _AvailableInShop;
        }
        /// <summary>
        /// An Item's price in the Shop
        /// </summary>
        public virtual long ShopPrice(ItemStack stack)
        {
            return _ShopPrice;
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

        public static Item FromID(string id)
        {
            foreach (Item itm in Registry.RegisteredItems)
            {
                if (itm.ID() == id)
                    return itm;
            }
            return null;
        }

        //
        //
        //

        protected void SetID(string s) { _ID = s; }
        protected void SetName(string s) { _Name = s; }
        protected void SetIcon(Image s) { _Icon = s; }
        protected void SetShopPrice(long s) { _ShopPrice = s; }
        protected void SetAvailableInShop(bool s) { _AvailableInShop = s; }
    }
}
