using PearXLib.Engine.Flat;
using System.Drawing;
using System.ComponentModel;

namespace pcs.Components.Controls
{
    public class PCSBar : FlatBar
    {
        [DefaultValue(typeof(Color), "White")]
        public override Color ProgressTextColor { get; set; } = Color.White;

        [DefaultValue(true)]
        public override bool Shadow { get; set; } = true;
    }
}
