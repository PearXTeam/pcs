using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using pcs.Components.Controls;
using pcs.Player;

namespace pcs.IAI
{
    public class Inventory : ObservableCollection<ItemStack>
    {
        public bool DoNotUpdate = false;
        public List<InventoryGUI> GUIs = new List<InventoryGUI>();

        public new void Add(ItemStack itm)
        {
            foreach (ItemStack stack in this)
            {
                if (!ItemStack.Equals(stack, itm, ItemStackCompareOptions.ByData)) continue;
                if (itm.StackCount + stack.StackCount > stack.Item.MaxStackSize(stack)) continue;

                stack.StackCount += itm.StackCount;
                return;
            }

            itm.PropertyChanged += ItemPropertyChanged;
            base.Add(itm);
        }

        public void Add(ItemStack stack, bool update)
        {
            DoNotUpdate = !update;
            Add(stack);
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (!DoNotUpdate)
            {
                base.OnCollectionChanged(e);
                UpdateGUIs();
            }
            else
                DoNotUpdate = false;
        }

        private void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace));
        }

        public void UpdateGUIs()
        {
            foreach (InventoryGUI gui in GUIs)
            {
                new Thread(() =>
                {
                    if (gui.IsHandleCreated)
                        gui.Invoke(new MethodInvoker(() => gui.Controls.Clear()));
                    else
                        gui.Controls.Clear();

                    int x = 0;
                    int y = 0;
                    foreach (var v in this)
                    {
                        if (x == gui.ItemsInRow)
                        {
                            x = 0;
                            y++;
                        }
                        PCSInvItemC item = new PCSInvItemC
                        {
                            ItemImage = v.Item.Icon(v),
                            ItemName = v.Item.Name(v),
                            ItemDesc = v.Item.Description(v),
                            ItemAmount = v.StackCount
                        };

                        int distance = x == gui.ItemsInRow ? 0 : gui.ItemsDistance;
                        item.Location = new Point(x*(item.Width + distance), y*item.Height);

                        item.MouseClick += (sender, args) =>
                        {
                            int index = PlayerInventory.Inventory.IndexOf(v);
                            ItemStack stack = PlayerInventory.Inventory[index];
                            switch (gui.ItemClickAction)
                            {
                                case ItemUseAction.Default:
                                    v.Item.OnUse(this, args.Button, ref stack);
                                    break;
                                case ItemUseAction.DefaultThenCustom:
                                    v.Item.OnUse(this, args.Button, ref stack);
                                    gui.OnCustomUseEvent(this, args.Button, ref stack);
                                    break;
                                case ItemUseAction.CustomThenDefault:
                                    gui.OnCustomUseEvent(this, args.Button, ref stack);
                                    v.Item.OnUse(this, args.Button, ref stack);
                                    break;
                                case ItemUseAction.Custom:
                                    gui.OnCustomUseEvent(this, args.Button, ref stack);
                                    break;
                            }
                        };


                        if (gui.IsHandleCreated)
                            gui.Invoke(new MethodInvoker(() => gui.Controls.Add(item)));
                        else
                            gui.Controls.Add(item);
                        x++;
                    }
                }).Start();
            }
        }
    }
}
