using System;
using pcs.Components;
using pcs.Components.IAI;
using pcs.Player;

namespace pcs.Commands
{
    public class CommandGive : Command
    {
        public override string Name()
        {
            return "give";
        }

        public override void OnPerform(string[] args, string allArgs)
        {
            int size = 1;
            string subID = "";

            switch (args.Length)
            {
                case 1:
                    break;
                case 2:
                    if(!int.TryParse(args[1], out size))
                        AddToConsole("command.give.size.nan");
                    break;
                case 3:
                    if (!int.TryParse(args[1], out size))
                        AddToConsole("command.give.size.nan");
                    subID = args[2];
                    break;
                default:
                    AddToConsole(PCS.Loc.GetString("command.give.incorrectUsage"));
                    return;
            }

            string s = args[0];
            foreach (Item itm in Registry.RegisteredItems)
            {
                if (string.Equals(itm.ID(), s, StringComparison.CurrentCultureIgnoreCase))
                {
                    ItemStack stack = new ItemStack(itm, size, subID);
                    AddToConsole(PCS.Loc.GetString("command.give.successfully").Replace("%s", itm.Name(stack)));
                    PlayerInventory.Inventory.Add(stack);
                    break;
                }
                AddToConsole(PCS.Loc.GetString("command.give.notFound"));
            }
        }
    }
}
