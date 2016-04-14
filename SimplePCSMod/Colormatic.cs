using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pcs.Modding;
using System.Drawing;
using pcs.Forms;
using pcs;
using pcs.Components;
using PearXLib;

namespace SimplePCSMod
{
    public class Colormatic : PCSMod
    {
        public string Author()
        {
            return "mrAppleXZ";
        }

        public void Init()
        {
            
        }

        public string ModID()
        {
            return "colormatic";
        }

        public string Name()
        {
            return "CoLoRmAtIc";
        }

        private Random rand = new Random();

        private Color RandCol()
        {
            return Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
        }

        public static bool COLOR_ON; 

        public void PostInit()
        {
            if (COLOR_ON)
            {
                Game.instance.BackColor = RandCol();
                Game.instance.PanelBG = RandCol();
                Game.instance.RimColor = RandCol();
                Game.instance.CloseBoxColor = RandCol();
                Game.instance.CloseBoxFColor = RandCol();
                Game.instance.barFood.GradientColor1 = RandCol();
                Game.instance.barFood.GradientColor2 = RandCol();
                Game.instance.barMood.GradientColor1 = RandCol();
                Game.instance.barMood.GradientColor2 = RandCol();
                Game.instance.barSleep.GradientColor1 = RandCol();
                Game.instance.barSleep.GradientColor2 = RandCol();
                Game.instance.barHealth.GradientColor1 = RandCol();
                Game.instance.barHealth.GradientColor2 = RandCol();
                Game.instance.lblMoney.ForeColor = RandCol();
                Game.instance.lblXP.ForeColor = RandCol();
            }
        }

        public void PreInit()
        {
            Registry.RegisteredCommands.Add(new CmdColormatic());
            Registry.RegisteredSaves.Add(new SaveElement("colormatic_enabled", (name, value) => COLOR_ON = Convert.ToBoolean(value), (string name, out string value) => value = COLOR_ON.ToString()));
        }

        public string Version()
        {
            return "ReD";
        }
    }

    class CmdColormatic : Command
    {
        public override string Name()
        {
            return "color";
        }

        public override void OnPerform(string[] args)
        {
            if (args.Length == 2)
            {
                switch (args[1])
                {
                    case "on":
                        Colormatic.COLOR_ON = true;
                        break;
                    case "off":
                        Colormatic.COLOR_ON = false;
                        break;
                    default:
                        AddToConsole("You must enter on/off as argument №2.");
                        break;
                }
            }
            else
                AddToConsole("Invalid args!", LogType.Warning);
        }
    }
}
