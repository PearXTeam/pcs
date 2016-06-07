using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using pcs.Components;
using pcs.Components.Controls;
using pcs.Components.IAI;
using pcs.Player;

namespace pcs.Forms
{
    public partial class InventoryGUI : PCSForm
    {
        public static InventoryGUI Instance = new InventoryGUI();

        public InventoryGUI()
        {
            InitializeComponent();
        }

        public void UpdateInventory()
        {
            new Thread(() =>
            {
                if(IsHandleCreated)
                    Invoke(new MethodInvoker(() => panelInv.Controls.Clear()));
                else
                    panelInv.Controls.Clear();

                int x = 0;
                int y = 0;
                foreach (var v in PlayerInventory.Inventory)
                {
                    PCSInvItemC item = new PCSInvItemC();
                    item.ItemImage = v.Item.Icon(v);
                    item.ItemName = v.Item.Name(v);
                    item.ItemDesc = v.Item.Description(v);
                    item.ItemAmount = v.StackCount;
                    item.Location = new Point(x * item.Width, y * item.Height);
                    item.MouseClick += (sender, args) =>
                    {
                        int index = PlayerInventory.Inventory.IndexOf(v);
                        ItemStack s = PlayerInventory.Inventory[index];
                        v.Item.OnUse(args.Button, ref s);
                        if(s != v)
                            PlayerInventory.Inventory[index] = s;
                    };
                    if (x == 7)
                    {
                        x = 0;
                        y++;
                    }
                    if(IsHandleCreated)
                        Invoke(new MethodInvoker(() => panelInv.Controls.Add(item)));
                    else
                        panelInv.Controls.Add(item);
                    x++;
                }
            }).Start();
        }
    }
}
