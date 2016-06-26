using System.Collections.ObjectModel;
using System.Collections.Specialized;
using pcs.Forms;

namespace pcs.IAI
{
    public class Inventory : ObservableCollection<ItemStack>
    {

        public new void Add(ItemStack itm)
        {
            foreach (ItemStack stack in this)
            {
                if (ItemStack.Equals(stack, itm, ItemStackCompareOptions.ByData))
                {
                    if (itm.StackCount + stack.StackCount <= stack.Item.MaxStackSize(stack))
                    {
                        stack.StackCount += itm.StackCount;
                        return;
                    }
                }
            }
            base.Add(itm);
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);
            InventoryGUI.UpdateInventory();
        }
    }
}
