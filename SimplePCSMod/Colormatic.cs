using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pcs.Modding;
using System.Drawing;
using pcs.Forms;

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

        public static bool COLOR_ON = false; 

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
            
        }

        public string Version()
        {
            return "ReD";
        }
    }
}
