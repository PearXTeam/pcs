using System.Windows.Forms;
using pcs.Components;
using pcs.Components.IAI;
using pcs.Components.Interfaces;
using pcs.Player;

namespace pcs.Items
{
    public class ItemBedTalisman : Item, ITickable
    {
        public ItemBedTalisman()
        {
            SetID("PCS:BedTalisman");
            SetName(PCS.Loc.GetString("item.bedTalisman"));
            SetAvailableInShop(false);
        }

        public void OnTick(ItemStack stack, byte tickNumber)
        {
            if (tickNumber == 5)
            {
                Stats.Sleep++;
            }
        }

        public override void OnUse(MouseButtons b, ref ItemStack stack)
        {
            new PopUp().Display("test", "test");
            PlayerInventory.Inventory.Remove(stack);
        }

        public bool IsAsync()
        {
            return false;
        }

        public override string Description(ItemStack stack)
        {
            return "Testing...";
        }
    }
}
