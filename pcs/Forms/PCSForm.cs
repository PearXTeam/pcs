using pcs.Properties;
using PearXLib.Engine.Flat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pcs.Forms
{
    public class PCSForm : FlatForm
    {
        public PCSForm()
        {
            Icon = Resources.PCSIcon;
        }

        private Font f = new Font("Yanone Kaffeesatz", 16F);

        public override Font Font
        {
            get
            {
                return f;
            }

            set
            {
                f = value;
            }
        }
        
    }
}
