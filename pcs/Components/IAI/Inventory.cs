using System.Collections.ObjectModel;
using System.Collections.Specialized;
using pcs.Forms;

namespace pcs.Components.IAI
{
    public class Inventory : ObservableCollection<ItemStack>
    {
        public new void Add(ItemStack itm)
        {
            base.Add(itm);
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);
            InventoryGUI.Instance.UpdateInventory();
        }
    }
}
