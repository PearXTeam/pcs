using pcs.Components;
using pcs.Core;
using pcs.Player;
using PearXLib;

namespace pcs.Commands
{
    public class CommandSet : Command
    {
        public override string Name()
        {
            return "set";
        }

        public override void OnPerform(string[] args, string allArgs)
        {
            switch (args.Length)
            {
                case 2:
                    int i;
                    if (int.TryParse(args[1], out i))
                    {
                        switch (args[0])
                        {
                            case "money":
                                PlayerVals.Money = i;
                                break;
                            case "xp":
                                PlayerVals.XP = i;
                                break;
                            case "food":
                                Stats.Food = i;
                                break;
                            case "sleep":
                                Stats.Sleep = i;
                                break;
                            case "health":
                                Stats.Health = i;
                                break;
                            case "mood":
                                Stats.Mood = i;
                                break;
                            case "mfood":
                                Stats.MaxFood = i;
                                break;
                            case "msleep":
                                Stats.MaxSleep = i;
                                break;
                            case "mhealth":
                                Stats.MaxHealth = i;
                                break;
                            case "mmood":
                                Stats.MaxMood = i;
                                break;
                            default:
                                AddToConsole(PCS.Loc.GetString("command.set.incorrectusage"), LogType.Warning);
                                break;
                        }
                        AddToConsole(PCS.Loc.GetString("command.set.successfully") + i);
                    }
                    else
                        AddToConsole(PCS.Loc.GetString("command.set.nan"), LogType.Warning);
                    break;
                default:
                    AddToConsole(PCS.Loc.GetString("command.set.incorrectusage"), LogType.Warning);
                    break;
            }
        }
    }
}
