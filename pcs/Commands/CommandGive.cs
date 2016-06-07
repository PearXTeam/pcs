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

        public override void OnPerform(string[] args)
        {
            switch (args.Length)
            {
                case 2:
                    string s = args[1];
                    foreach (Item itm in Registry.RegisteredItems)
                    {
                        if (itm.ID() == s)
                        {
                            PlayerInventory.Inventory.Add(new ItemStack(itm));
                            break;
                        }
                        AddToConsole(PCS.Loc.GetString("command.give.notFound"));
                    }
                    break;
                default:
                    AddToConsole(PCS.Loc.GetString("command.give.incorrectUsage"));
                    break;
            }
        }
    }
}
