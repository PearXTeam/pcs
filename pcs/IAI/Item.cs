using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private bool _IsAvailableInShop;
        private string _Tooltip;

        public Item() { }
        public Item(string name, string id, Image icon, long shopPrice = 100, string tooltip = "", bool availableInShop = true)
        {
            _Name = name;
            _ID = id;
            _Icon = icon;
            _ShopPrice = shopPrice;
            _IsAvailableInShop = availableInShop;
            _Tooltip = tooltip;
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
        public virtual string Tooltip(ItemStack stack)
        {
            return _Tooltip;
        }

        /// <summary>
        /// Max stack size.
        /// </summary>
        public virtual long MaxStackSize(ItemStack stack)
        {
            return 128;
        }

        /// <summary>
        /// Returns all available SubIDs.
        /// </summary>
        /// <returns>All available SubIDs</returns>
        public virtual List<string> GetSubIDs()
        {
            return new List<string>();
        }

        //SHOP \/

        /// <summary>
        /// Is this Item available in the Shop?
        /// </summary>
        public virtual bool IsAvailableInShop()
        {
            return _IsAvailableInShop;
        }

        /// <summary>
        /// An Item's price in the Shop.
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
        /// Returns an Item by it's ID.
        /// </summary>
        /// <param name="id">The Item's ID.</param>
        /// <returns>An Item</returns>
        public static Item FromID(string id)
        {
            return Registry.RegisteredItems.FirstOrDefault(itm => itm.ID() == id);
        }

        /// <summary>
        /// Buy Item
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="stack">ItemStack to buy.</param>
        public static void Buy(object sender, ref ItemStack stack)
        {
            if (stack.Item.CanBuy(stack))
            {
                stack.Item.BuyEvent?.Invoke(sender, ref stack);
                PlayerVals.Money -= stack.Item.ShopPrice(stack);
                PlayerInventory.Inventory.Add(stack);
            }
        }

        /// <summary>
        /// Occurs when player buys this Item.
        /// </summary>
        public event ItemBuyHandler BuyEvent;

        public virtual void OnBuy(object sender, ref ItemStack stack)
        {
            BuyEvent?.Invoke(sender, ref stack);
        }

        /// <summary>
        /// Occurs when player clicks this Item in his inventory.
        /// </summary>
        public event ItemUseHandler UseEvent;

        public virtual void OnUse(object sender, MouseButtons b, ref ItemStack stack)
        {
            UseEvent?.Invoke(sender, b, ref stack);
        }

        public void SetID(string s) { _ID = s; }
        public void SetName(string s) { _Name = s; }
        public void SetIcon(Image s) { _Icon = s; }
        public void SetShopPrice(long s) { _ShopPrice = s; }
        public void SetAvailableInShop(bool s) { _IsAvailableInShop = s; }
        public void SetTooltip(string s) { _Tooltip = s; }
    }

    /// <summary>
    /// Item Buy handler.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="stack">ItemStack to buy.</param>
    public delegate void ItemBuyHandler(object sender, ref ItemStack stack);

    /// <summary>
    /// Item Use handler.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="b">Mouse Button</param>
    /// <param name="stack">Clicked ItemStack</param>
    public delegate void ItemUseHandler(object sender, MouseButtons b, ref ItemStack stack);
}
