using pcs.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs.Commands
{
    class CommandMaxStats : SCommand
    {
        public string Command() { return "maxStats"; }
        public void OnPerform(string[] args)
        {
            v.Food = 100;
            v.Mood = 100;
            v.Purity = 100;
            v.Sleep = 100;
        }
    }
}
