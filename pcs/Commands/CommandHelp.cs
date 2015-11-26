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
            sb.Append(v.l.GetString("command.help.msg"));
            int count = 0;
            foreach(SCommand sc in Registry.RegisteredCommands)
            {
                count++;
                sb.Append(sc.Command().ToString());
                if (count != Registry.RegisteredCommands.Count)
                    sb.Append(", ");
                else
                    sb.Append(".");
            }
            v.Log.Add(sb.ToString(), LogType.Info);
        }
    }
}
