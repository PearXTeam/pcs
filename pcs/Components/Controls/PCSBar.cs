using PearXLib.Engine.Flat;
using System.Drawing;
using System.ComponentModel;

namespace pcs.Components.Controls
{
    public class PCSBar : FlatBar
    {
        private Color clr = Color.White;
        private bool shadow = true;

        [DefaultValue(typeof(Color), "White")]
        public override Color ProgressTextColor
        {
            get
            {
                return clr;
            }

            set
            {
                clr = value;
            }
        }
        
        [DefaultValue(true)]
        public override bool Shadow { get { return shadow; } set { shadow = value; } }
    }
}
