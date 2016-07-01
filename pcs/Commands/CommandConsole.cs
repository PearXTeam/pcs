using pcs.Components;
using pcs.Core;

namespace pcs.Commands
{
    public class CommandConsole : Command
    {
        public override string Name()
        {
            return "console";
        }

        public override void OnPerform(string[] args, string allArgs)
        {
            switch (args.Length)
            {
                case 0:
                    AddToConsole(PCS.Loc.GetString("command.console.incorrectUsage"));
                    break;
                default:
                    switch (args[0])
                    {
                        case "clear":
                            ClearConsole();
                            break;
                    }
                    break;
            }
        }
    }
}
