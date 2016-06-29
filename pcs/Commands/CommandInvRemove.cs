using pcs.Components;
using pcs.Core;
using pcs.Player;

namespace pcs.Commands
{
    public class CommandInvRemove : Command
    {
        public override string Name()
        {
            return "inv_remove";
        }

        public override void OnPerform(string[] args, string allArgs)
        {
            switch (args.Length)
            {
                case 0:
                    AddToConsole(PCS.Loc.GetString("command.invRemove.incorrectUsage"));
                    break;
                default:
                    int i;
                    if (int.TryParse(args[0], out i))
                    {
                        PlayerInventory.Inventory.Remove(PlayerInventory.Inventory[i]);
                        AddToConsole(PCS.Loc.GetString("command.invRemove.successfully"));
                    }
                    else if (args[0] == "all")
                    {
                        PlayerInventory.Inventory.Clear();
                        AddToConsole(PCS.Loc.GetString("command.invRemove.successfully"));
                    }
                    else
                        AddToConsole(PCS.Loc.GetString("command.invRemove.incorrectUsage"));
                    break;
            }
        }
    }
}
