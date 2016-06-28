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
    public partial class PlayerInventoryGUI : PCSForm
    {
        public static PlayerInventoryGUI Instance = new PlayerInventoryGUI();

        public PlayerInventoryGUI()
        {
            InitializeComponent();
            PlayerInventory.Inventory.GUIs.Add(playerInventory);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            PlayerInventory.Inventory.UpdateGUIs();
        }
    }
}
