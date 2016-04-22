using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using PearXLib.Engine.Flat;

namespace pcs.Components
{
    public class PCSButton : FlatButton
    {
        private bool shadow = true;
        private Color c = Color.White;

        [DefaultValue(true)]
        public override bool Shadow { get { return shadow; } set { shadow = value; } }

        [DefaultValue(typeof(Color), "White")]
        public override Color ForeColor { get { return c; } set { c = value; } }
    }
}
