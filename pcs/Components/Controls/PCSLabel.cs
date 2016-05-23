using System.ComponentModel;
using System.Drawing;
using PearXLib.Engine;

namespace pcs.Components.Controls
{
    public class PCSLabel : XLabel
    {
        private Color fore = Color.FromArgb(41, 128, 185);
        private bool sh = true;

        [DefaultValue(typeof(Color), "41, 128, 185")]
        public override Color ForeColor
        {
            get
            {
                return fore;
            }

            set
            {
                fore = value;
            }
        }

        [DefaultValue(true)]
        public override bool Shadow { get { return sh; } set { sh = value; Refresh(); } }
    }
}
