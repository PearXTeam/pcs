using pcs.Types;
using System;
using System.Numerics;
using PearXLib;

namespace pcs.Commands
{
    public class CommandSet : SCommand
    {
        public string Command() { return "set"; }
        public void OnPerform(string[] args)
        {
            if (args.Length == 3)
            {
                if (!String.IsNullOrWhiteSpace(args[1]) && !String.IsNullOrWhiteSpace(args[2]))
                {
                   BigInteger i;
                   if(BigInteger.TryParse(args[2], out i))
                   {
                       if (args[1] == "money" || args[1] == "xp")
                       {
                           switch (args[1])
                           {
                               case "money":
                                   v.Money = BigInteger.Parse(args[2]);
                                   v.Log.Add(v.l.GetString("command.set.money") + args[2] + " " + v.l.GetString("other.currency"), LogType.Info);
                                   break;
                               case "xp":
                                   v.XP = BigInteger.Parse(args[2]);
                                   v.Log.Add(v.l.GetString("command.set.xp") + args[2] + " " + v.l.GetString("other.XPName"), LogType.Info);
                                   break;
                           }
                       }
                       else
                       {
                           v.Log.Add(v.l.GetString("command.set.error"), LogType.Warning);
                       }
                   }
                   else
                   {
                       v.Log.Add(v.l.GetString("command.set.amountError"), LogType.Warning);
                   }
                }
            }
            else
            {
                v.Log.Add(v.l.GetString("command.set.argumentError"), LogType.Warning);
            }
        }
    }
}
