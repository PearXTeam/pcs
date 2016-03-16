using pcs;
using pcs.Components;
using pcs.Forms;
using pcs.Modding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimplePCSMod
{
    class Program : PCSMod
    {
        private bool test = false;

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

        public void PreInit()
        {
            if (test)
            {
                PCSLabel lbl = new PCSLabel();
                lbl.Text = "test ahahahah";
                lbl.Location = new Point(30, 30);
                Game.instance.Controls.Add(lbl);
            }
            
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
