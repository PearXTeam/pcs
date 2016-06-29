using pcs.Commands;
using pcs.Components;

namespace pcs.Init
{
    public class PCSCommands
    {
        public static Command Restore = new CommandRestore();
        public static Command Help = new CommandHelp();
        public static Command Set = new CommandSet();
        public static Command Time = new CommandTime();
        public static Command Give = new CommandGive();
        public static Command Items = new CommandItems();
        public static Command Stats = new CommandStats();
        public static Command InvRemove = new CommandInvRemove();
    }
}
