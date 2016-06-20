using System.ComponentModel;
using System.Drawing;
using PearXLib.Engine.Flat;

namespace pcs.Components.Controls
{
    public class PCSButton : FlatButton
    {
        [DefaultValue(true)]
        public override bool Shadow { get; set; } = true;

        [DefaultValue(typeof(Color), "White")]
        public override Color ForeColor { get; set; } = Color.White;
    }
}
