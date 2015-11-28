using pcs.Types;

namespace pcs.Commands
{
    public class CommandDisableStats : SCommand
    {
        public string Command() { return "disableStats"; }
        public void OnPerform(string[] args)
        {
            v.g.timerFood.Stop();
            v.g.timerMood.Stop();
            v.g.timerPurity.Stop();
            v.g.timerSleep.Stop();
            v.Log.Add(v.l.GetString("command.disableStats.msg"), PearXLib.LogType.Info);
        }
    }
}