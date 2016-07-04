using System.Drawing;
using PearXLib.Engine;

namespace pcs.Components.Controls
{
    public class PCSInvItem : InvItem
    {
        public PCSInvItem()
        {
            Font = new Font("Yanone Kaffeesatz F", 20F);
            Size = new Size(411, 137);
            ShowAmount = false;
            ColorDesc = Color.FromArgb(52, 152, 219);
            Shadow = true;
        }
    }
}
