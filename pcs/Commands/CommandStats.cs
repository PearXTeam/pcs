using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pcs.Components;
using pcs.Core;
using pcs.Forms;

namespace pcs.Commands
{
    public class CommandStats : Command
    {
        public override string Name()
        {
            return "stats";
        }

        public override void OnPerform(string[] args, string allArgs)
        {
            switch (args.Length)
            {
                case 0:
                    AddToConsole(PCS.Loc.GetString("command.stats.incorrectUsage"));
                    break;
                default:
                    switch (args[0])
                    {
                        case "on":
                            Game.instance.timerFood.Start();
                            Game.instance.timerMood.Start();
                            Game.instance.timerSleep.Start();
                            AddToConsole(PCS.Loc.GetString("command.stats.on"));
                            break;
                        case "off":
                            Game.instance.timerFood.Stop();
                            Game.instance.timerMood.Stop();
                            Game.instance.timerSleep.Stop();
                            AddToConsole(PCS.Loc.GetString("command.stats.off"));
                            break;
                        default:
                            AddToConsole(PCS.Loc.GetString("command.stats.incorrectUsage"));
                            break;
                    }
                    break;
            }
        }
    }
}
