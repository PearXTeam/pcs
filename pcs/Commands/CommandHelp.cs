using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pcs.Components;

namespace pcs.Commands
{
    public class CommandHelp : Command
    {
        public override string Name()
        {
            return "help";
        }

        public override void OnPerform(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(PCS.Loc.GetString("command.help.avaible"));
            foreach (var v in Registry.RegisteredCommands)
            {
                sb.Append(v.Name() + ", ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append(".");
            AddToConsole(sb.ToString());
        }
    }
}
