using pcs;
using pcs.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplePCSMod
{
    class Program : PCSMod
    {
        public void Init()
        {
            
        }

        public string ModID()
        {
            return "simplepcsmod";
        }

        public string Name()
        {
            return "A Simple PCS Mod";
        }

        public void OnStart()
        {
            Crash.GetAnotherCrashInfo += Crash_GetAnotherCrashInfo;
            Crash.GetAnotherCrashInfo += Crash_GetAnotherCrashInfo1;
        }

        private void Crash_GetAnotherCrashInfo1(object sender, UnhandledExceptionEventArgs e, ref List<string> toReturn)
        {
            toReturn.Add("pukan");
        }

        private void Crash_GetAnotherCrashInfo(object sender, UnhandledExceptionEventArgs e, ref List<string> toReturn)
        {
            toReturn.Add("PERDET' - VESELO!!!");
        }

        public void PostInit()
        {
            
        }

        public string Version()
        {
            return "1.0.0";
        }
    }
}
