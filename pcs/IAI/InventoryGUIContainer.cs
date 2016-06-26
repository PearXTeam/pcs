using System.ComponentModel;
using System.Windows.Forms;

namespace pcs.IAI
{
    public class InventoryGUIContainer : Panel
    {

        [DefaultValue(true)]
        public override bool AutoScroll { get; set; } = true;

        [DefaultValue(0)]
        public InventoryType Type { get; set; } = InventoryType.Player;

        [DefaultValue(8)]
        public int ItemsInRow { get; set; } = 8;

        [DefaultValue(4)]
        public int ItemsDistance { get; set; } = 4;
        
    }
}
