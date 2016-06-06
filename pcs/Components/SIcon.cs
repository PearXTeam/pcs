using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pcs.Components
{
    public class SIcon
    {
        public virtual Image GetIcon()
        {
            return PCSImages.UndefinedIcon;
        }

        public virtual void OnClick(object sender, EventArgs e)
        {
            
        }

        public virtual string GetName()
        {
            return "Undefined Icon";
        }
    }
}
