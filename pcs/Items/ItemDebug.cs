using System.Threading;
using System.Windows.Forms;
using pcs.Forms;
using pcs.IAI;

namespace pcs.Items
{ 
    public class ItemDebug : Item
    {
        public ItemDebug()
        {
            SetName("Debugging Item");
            SetAvailableInShop(false);
            SetID("PCS:Debug");
        }

        public override void OnUse(MouseButtons b, ref ItemStack stack)
        {
            if (b == MouseButtons.Left)
            {
                Game.instance.Invoke(new MethodInvoker(() => { Thread.Sleep(1000); }));
            }
            else if(b == MouseButtons.Right)
                Game.instance.Invoke(new MethodInvoker(() => { Thread.Sleep(15000); }));
        }
    }
}
