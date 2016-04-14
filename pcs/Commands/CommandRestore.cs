using pcs.Components;
using pcs.Player;
using PearXLib;

namespace pcs.Commands
{
    public class CommandRestore : Command
    {
        public override string Name()
        {
            return "restore";
        }

        public override void OnPerform(string[] args)
        {
            Stats.Food = Stats.MaxFood;
            Stats.Mood = Stats.MaxMood;
            Stats.Sleep = Stats.MaxSleep;
            Stats.Health = Stats.MaxHealth;
            AddToConsole(PCS.Loc.GetString("command.restore.all"));
        }
    }
}
