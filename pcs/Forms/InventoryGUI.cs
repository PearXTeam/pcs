using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using pcs.Components;
using pcs.Components.Controls;
using pcs.IAI;
using pcs.Player;

namespace pcs.Forms
{
    public partial class InventoryGUI : PCSForm, IInventory
    {
        public static InventoryGUI Instance = new InventoryGUI();

        public InventoryGUI()
        {
            InitializeComponent();
            
        }

        public static void UpdateInventory()
        {
            new Thread(() =>
            {
                foreach (var c in InventoryUtils.GetInventories())
                {
                    if (c.Type == InventoryType.Player)
                    {
                        if (c.IsHandleCreated)
                            c.Invoke(new MethodInvoker(() => c.Controls.Clear()));
                        else
                            c.Controls.Clear();

                        int x = 0;
                        int y = 0;
                        foreach (var v in PlayerInventory.Inventory)
                        {
                            if (x == c.ItemsInRow)
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

                            int distance = x == c.ItemsInRow ? 0 : c.ItemsDistance;
                            item.Location = new Point(x * (item.Width + distance), y * item.Height);

                            item.MouseClick += (sender, args) =>
                            {
                                int index = PlayerInventory.Inventory.IndexOf(v);
                                ItemStack s = PlayerInventory.Inventory[index];
                                v.Item.OnUse(args.Button, ref s);
                            };
                            

                            if (c.IsHandleCreated)
                                c.Invoke(new MethodInvoker(() => c.Controls.Add(item)));
                            else
                                c.Controls.Add(item);
                            x++;
                        }
                    }
                }
            }).Start();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            UpdateInventory();
        }
    }
}
