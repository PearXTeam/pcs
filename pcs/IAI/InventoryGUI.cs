using System.ComponentModel;
using System.Windows.Forms;

namespace pcs.IAI
{
    public class InventoryGUI : Panel
    {

        [DefaultValue(true)]
        public override bool AutoScroll { get; set; } = true;

        [DefaultValue(0)]
        public InventoryType Type { get; set; } = InventoryType.Container;

        [DefaultValue(8)]
        public int ItemsInRow { get; set; } = 8;

        [DefaultValue(4)]
        public int ItemsDistance { get; set; } = 4;

        [DefaultValue(0)]
        public ItemUseAction ItemClickAction { get; set; } = ItemUseAction.Default;

        public event ItemUseHandler CustomUseEvent;

        public void OnCustomUseEvent(object sender, MouseButtons b, ref ItemStack stack)
        {
            CustomUseEvent?.Invoke(sender, b, ref stack);
        }
        
    }
}