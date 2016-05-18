using System;
using System.Drawing;

namespace pcs.Components
{
    public class SToolIcon
    {
        public virtual Image GetIcon()
        {
            return PCSImages.UndefinedToolIcon;
        }
        
        public virtual void OnClick(object sender, EventArgs e)
        {
            
        }

        public virtual string Desc()
        {
            return "I'm a ToolIcon ;)";
        }
    }
}
