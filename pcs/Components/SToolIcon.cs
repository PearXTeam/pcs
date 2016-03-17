using pcs.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pcs.Components
{
    public class SToolIcon
    {
        public virtual Image GetIcon()
        {
            return Resources.UndefinedToolIcon;
        }
        
        public virtual void OnClick(object sender, EventArgs e)
        {
            
        }
    }
}
