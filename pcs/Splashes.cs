using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs
{
    class Splashes
    {
        public static string GenCrashSplash()
        {
            switch (PCS.Rand.Next(6))
            {
                case 0:
                    return "We're sorry :(.";
                case 1:
                    return "Crash?";
                case 2:
                    return "Crash!";
                case 3:
                    return "My bad..";
                case 4:
                    return "Developer! Developer! Are you here?";
                case 5:
                    return "Bugs! They are everywhere!";
                default:
                    return ".";
            }
        }
    }
}
