using System;
using pcs.Components;
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
