using System.Collections.Generic;
using System.Linq;
using pcs.Components;
using pcs.Core;
using pcs.IAI;

namespace pcs.Commands
{
    public class CommandItems : Command
    {
        public override string Name()
        {
            return "items";
        }

        public override void OnPerform(string[] args, string allArgs)
        {
            List<string> l = new List<string>();
            foreach (Item itm in Registry.RegisteredItems)
            {
                l.Add(itm.ID());
                l.AddRange(itm.GetSubIDs().Select(s => itm.ID() + " " + s));
            }
            AddToConsole(PCS.Loc.GetString("command.items.available") + string.Join(", ", l) + ".");
        }
    }
}
