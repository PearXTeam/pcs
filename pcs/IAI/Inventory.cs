using System.Collections.ObjectModel;
using System.Collections.Specialized;
using pcs.Forms;

namespace pcs.IAI
{
    public class Inventory : ObservableCollection<ItemStack>
    {
        private bool notUpdate;

        public void Add(ItemStack stack, bool update)
        {
            if (update == false)
                notUpdate = true;
            
            base.Add(stack);
        }

        public new void Add(ItemStack itm)
        {
            base.Add(itm);
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);
            if(!notUpdate)
                //InventoryGUI.UpdateInventory();
            notUpdate = false;
        }
    }
}
