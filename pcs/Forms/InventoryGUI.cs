using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using pcs.Components;
using pcs.Components.Controls;
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
                Invoke(new MethodInvoker(() => panelInv.Controls.Clear()));
                foreach (var v in PlayerInventory.Inventory)
                {
                    PCSInvItemC item = new PCSInvItemC();
                    item.ItemImage = v.Item.Icon(v);
                    item.ItemName = v.Item.Name(v);
                    item.ItemDesc = v.Item.Description(v);
                    item.ItemAmount = v.StackCount;
                }
            }).Start();
        }
    }
}
