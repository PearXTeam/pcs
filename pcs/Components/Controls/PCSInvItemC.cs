using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using PearXLib.Engine;

namespace pcs.Components.Controls
{
    public class PCSInvItemC : CompactInvItem
    {
        public PCSInvItemC()
        {
            Shadow = true;
            Tooltip.NameLabel.Font = Font;
            Tooltip.TooltipLabel.Font = new Font(Font.FontFamily, Font.Size - 3F);
        }
    }
}
