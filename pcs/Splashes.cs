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
                default:
                    return ".";
            }
        }
    }
}
