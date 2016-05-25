namespace pcs.Components.IAI
{
    public class ItemStack
    {
        protected ObjectData _Data = new ObjectData();
        protected Item _Item = new Item();
        protected long _StackCount = 1;
        protected string _SubID = "";

        public ItemStack(Item itm, int count, string subID)
        {
            Item = itm;
            StackCount = count;
            SubID = subID;
        }

        /// <summary>
        /// An Item's data.
        /// </summary>
        public ObjectData Data
        {
            get { return _Data; }
            set { _Data = value; }
        }

        /// <summary>
        /// An Item's data.
        /// </summary>
        public Item Item
        {
            get { return _Item; }
            set { _Item = value; }
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
        /// Item's sub-ID.
        /// </summary>
        public virtual string SubID
        {
            get { return _SubID; }
            set { _SubID = value; }
        }
    }
}
