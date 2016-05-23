using pcs.Components;

namespace pcs.Commands
{
    public class PCSCommands
    {
        public static Command Restore = new CommandRestore();
        public static Command Help = new CommandHelp();
        public static Command Set = new CommandSet();
        public static Command Time = new CommandTime();
    }
}
