using pcs.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs.Commands
{
    class CommandMaxState : SCommand
    {
        public string Command() { return "maxState"; }
        public void OnPerform(string[] args)
        {
            if (args.Length == 2)
            {
                if (!String.IsNullOrWhiteSpace(args[1]))
                {
                    if (args[1] == "all" || args[1] == "food" || args[1] == "purity" || args[1] == "sleep" || args[1] == "health" || args[1] == "mood")
                    {
                        switch (args[1])
                        {
                            case "all":
                                v.Food = 100;
                                v.Purity = 100;
                                v.Sleep = 100;
                                v.Health = 100;
                                v.Mood = 100;
                                break;
                            case "food":
                                v.Food = 100;
                                break;
                            case "purity":
                                v.Purity = 100;
                                break;
                            case "sleep":
                                v.Sleep = 100;
                                break;
                            case "health":
                                v.Health = 100;
                                break;
                            case "mood":
                                v.Mood = 100;
                                break;
                        }
                        v.Log.Add(v.l.GetString("command.maxState.msg1") + args[1] + v.l.GetString("command.maxState.msg2"), PearXLib.LogType.Info);
                    }
                    else
                    {
                        v.Log.Add(v.l.GetString("command.maxState.error"), PearXLib.LogType.Warning);
                    }
                }
            }
            else
            {
                v.Log.Add(v.l.GetString("command.maxState.argumentError"), PearXLib.LogType.Warning);
            }
        }
    }
}
