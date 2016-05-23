using System.ComponentModel;
using System.Drawing;
using PearXLib.Engine.Flat;

namespace pcs.Components.Controls
{
    public class PCSCheckbox : FlatCheckbox
    {
        private bool shadow = true;
        public PCSCheckbox()
        {
            ForeColor = Color.FromArgb(41, 128, 185);
        }

        [DefaultValue(true)]
        public override bool Shadow { get { return shadow; } set { shadow = value; } }
    }
}
