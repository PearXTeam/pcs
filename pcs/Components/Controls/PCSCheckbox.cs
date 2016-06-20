using System.ComponentModel;
using System.Drawing;
using PearXLib.Engine.Flat;

namespace pcs.Components.Controls
{
    public class PCSCheckbox : FlatCheckbox
    {
        public PCSCheckbox()
        {
            ForeColor = Color.FromArgb(41, 128, 185);
        }

        [DefaultValue(true)]
        public override bool Shadow { get; set; } = true;
    }
}
