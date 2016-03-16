using PearXLib.Engine.Flat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pcs.Components
{
    public class PCSBar : FlatBar
    {
        private Color clr = Color.FromArgb(41, 128, 185);

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
    }
}
