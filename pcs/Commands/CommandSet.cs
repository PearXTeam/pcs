using pcs.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace pcs.Commands
{
    class CommandSet : SCommand
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
                       switch(args[1])
                       {
                           case "money":
                               v.Money = BigInteger.Parse(args[2]);
                               break;
                           case "xp":
                               v.XP = BigInteger.Parse(args[2]);
                               break;
                       }
                   }
                }
            }
        }
    }
}
