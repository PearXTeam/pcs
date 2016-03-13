using pcs;
using pcs.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
            Thread.Sleep(228);
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
