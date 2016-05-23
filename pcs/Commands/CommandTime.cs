using System;
using pcs.Components;
using pcs.Player;
using PearXLib;

namespace pcs.Commands
{
    public class CommandTime : Command
    {
        public override string Name()
        {
            return "time";
        }

        public override void OnPerform(string[] args)
        {
            switch (args.Length)
            {
                case 2:
                    int newHours;
                    if (int.TryParse(args[1], out newHours))
                    {
                        try
                        {
                            var v = PlayerVals.Time;
                            PlayerVals.Time = new DateTime(v.Year, v.Month, v.Day, newHours, v.Minute, v.Second);
                            AddToConsole(PCS.Loc.GetString("command.time.successfully"));
                        }
                        catch { AddToConsole(PCS.Loc.GetString("command.time.cannotConvertToDateTime")); }
                    }
                    else
                    {
                        AddToConsole(PCS.Loc.GetString("command.time.incorrectargs"));
                    }
                    break;
                case 5:
                    int newYear, newMonth, newDay, newHrs;
                    if (int.TryParse(args[1], out newDay) && int.TryParse(args[2], out newMonth) && int.TryParse(args[3], out newYear) && int.TryParse(args[4], out newHrs))
                    {
                        try
                        {
                            var v = PlayerVals.Time;
                            PlayerVals.Time = new DateTime(newYear, newMonth, newDay, newHrs, v.Minute, v.Second);
                            AddToConsole(PCS.Loc.GetString("command.time.successfully"));
                        }
                        catch { AddToConsole(PCS.Loc.GetString("command.time.cannotConvertToDateTime")); }
                    }
                    else
                    {
                        AddToConsole(PCS.Loc.GetString("command.time.incorrectargs"));
                    }
                    break;
                default:
                    AddToConsole(PCS.Loc.GetString("command.time.incorrectusage"), LogType.Warning);
                    break;
            }
        }
    }
}
