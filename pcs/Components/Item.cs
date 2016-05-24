using System.Drawing;
using System.Windows.Forms;
using pcs.Player;

namespace pcs.Components
{
    public class Item
    {
        protected ObjectData _Data = new ObjectData();
        protected string _Name = "Undefined";
        protected string _ID = "PCS_UndefinedItem";
        protected string _SubID = "";
        protected Image _Icon = PCSImages.MissingIcon;
        protected string _Description = "";
        protected long _ShopPrice = 100;
        protected long _StackCount = 1;
        protected long _MaxStackSize = 100;

        public Item() { }

        /// <summary>
        /// An Item's data.
        /// </summary>
        public virtual ObjectData Data
        {
            get { return _Data; }
            set { _Data = value; }
        }


        /// <summary>
        /// A name of the Item
        /// </summary>
        /// <returns></returns>
        public virtual string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// An ID of the Item
        /// </summary>
        /// <returns></returns>
        public virtual string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /// <summary>
        /// The sub-ID of the Item. You can use this for Item colors and other stuff.
        /// </summary>
        /// <returns></returns>
        public virtual string SubID
        {
            get { return _SubID; }
            set { _SubID = value; }
        }

        /// <summary>
        /// The 64x64 item's icon
        /// </summary>
        /// <returns></returns>
        public virtual Image Icon
        {
            get { return _Icon; }
            set { _Icon = value; }
        }

        /// <summary>
        /// The description of the item.
        /// </summary>
        /// <returns></returns>
        public virtual string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        /// <summary>
        /// Items in stack
        /// </summary>
        public virtual long StackCount
        {
            get { return _StackCount; }
            set { _StackCount = value; }
        }

        /// <summary>
        /// Max stack size.
        /// </summary>
        public virtual long MaxStackSize
        {
            get { return _MaxStackSize; }
            set { _MaxStackSize = value; }
        }


        //SHOP \/

        /// <summary>
        /// An Item's price in the Shop
        /// </summary>
        public virtual long ShopPrice
        {
            get { return _ShopPrice; }
            set { _ShopPrice = value; }
        }

        /// <summary>
        /// Can player buy this item?
        /// </summary>
        /// <returns></returns>
        public virtual bool CanBuy()
        {
            if (PlayerVals.Money >= ShopPrice)
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
        /// On buy.
        /// </summary>
        public virtual void OnBuy() { }

        /// <summary>
        /// Buy this item.
        /// </summary>
        public virtual void Buy()
        {
            OnBuy();
            PlayerVals.Money -= ShopPrice;
            PlayerInventory.Inventory.Add(this);
        }

        //Events:
        /// <summary>
        /// Performs on player clicked this item in his inventory.
        /// </summary>
        /// <param name="b">Mouse Button</param>
        public virtual void OnClick(MouseButtons b)
        {
            
        }
    }
}
