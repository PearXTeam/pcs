using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs.Components
{
    public class PCSLabel : Label
    {
        private Color fore = Color.FromArgb(41, 128, 185);

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
    }
}
