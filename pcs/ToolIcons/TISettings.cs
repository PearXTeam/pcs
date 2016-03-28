﻿using pcs.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using pcs.Properties;
using pcs.Forms;

namespace pcs.ToolIcons
{
    public class TISettings : SToolIcon
    {
        public static TISettings ins = new TISettings();

        public override Image GetIcon()
        {
            return Resources.Settings;
        }

        public override void OnClick(object sender, EventArgs e)
        {
            Options.instance.ShowDialog(Game.instance);
        }

        public override string Desc()
        {
            return PCS.Loc.GetString("title.options");
        }
    }
}
