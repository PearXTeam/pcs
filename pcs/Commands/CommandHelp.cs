using pcs.Types;
using PearXLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace pcs.Commands
{
    class CommandHelp : SCommand
    {
        public string Command() { return "help"; }
        public void OnPerform(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            foreach(SCommand sc in Registry.RegisteredCommands)
            {
                sb.Append(sc.Command().ToString() + ", ");
            }
            v.Log.Add(sb.ToString(), LogType.Info);
        }
    }
}
