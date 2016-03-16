using PearXLib.Engine.Flat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace pcs.Components
{
    public class PCSBar : FlatBar
    {
        private Color clr = Color.White;

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
    }
}
