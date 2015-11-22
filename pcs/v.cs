using PearXLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace pcs
{
    public class v
    {
        //Not changeable values:
        public static readonly string PathToDir = d.pxDir + PXL.s + "PCSimulator" + PXL.s;
        public static readonly string Version = "1.0_alpha";
        //
        public static Localization l;
        public static Game g = new Game();
        public static List<Assembly> asms = new List<Assembly>();
        public static Logging Log = new Logging(PathToDir + "PCS.log");


        #region Private vars
        private static short _Food = 100;
        private static short _Mood = 100;
        private static short _Sleep = 100;
        private static short _Purity = 100;
        private static short _Health = 100;
        private static BigInteger _Money = 500;
        private static BigInteger _XP = 100;
        #endregion
        

        public static short Food
        {
            get
            {
                return _Food;
            }
            set
            {
                if (value <= 0)
                {
                    a.Kill(KilledBy.Hunger);
                }
                else
                {
                    if (value > 100)
                    {
                        value = 100;
                    }
                }
                g.barFood.Value = value;
                g.barFood.ProgressText = l.GetString("bar.food") + value.ToString() + "%";
                _Food = value;
            }
        }
        public static short Mood
        {
            get
            {
                return _Mood;
            }
            set
            {
                if (value <= 0)
                {
                    a.Kill(KilledBy.Bore);
                }
                else
                {
                    if (value > 100)
                    {
                        value = 100;
                    }
                }
                g.barMood.Value = value;
                g.barMood.ProgressText = l.GetString("bar.mood") + value.ToString() + "%";
                _Mood = value;
            }
        }
        public static short Sleep
        {
            get
            {
                return _Sleep;
            }
            set
            {
                if (value <= 0)
                {
                    a.Kill(KilledBy.LackOfSleep);
                }
                else
                {
                    if (value > 100)
                    {
                        value = 100;
                    }
                }
                g.barSleep.Value = value;
                g.barSleep.ProgressText = l.GetString("bar.sleep") + value.ToString() + "%";
                _Sleep = value;
            }
        }
        public static short Purity
        {
            get
            {
                return _Purity;
            }
            set
            {
                if (value <= 0)
                {
                    a.Kill(KilledBy.Mud);
                }
                else
                {
                    if (value > 100)
                    {
                        value = 100;
                    }
                }
                g.barPurity.Value = value;
                g.barPurity.ProgressText = l.GetString("bar.purity") + value.ToString() + "%";
                _Purity = value;
            }
        }
        public static short Health
        {
            get
            {
                return _Health;
            }
            set
            {
                if (value <= 0)
                {
                    a.Kill(KilledBy.Disease);
                }
                else
                {
                    if (value > 100)
                    {
                        value = 100;
                    }
                }
                g.barHealth.Value = value;
                g.barHealth.ProgressText = l.GetString("bar.health") + value.ToString() + "%";
                _Health = value;
            }
        }
        public static BigInteger Money
        {
            get { return _Money; }
            set
            {
                g.labelMoneys.Text = l.GetString("label.moneys") + value.ToString() + " " + l.GetString("other.currency");
                _Money = value;
            }
        }
        public static BigInteger XP
        {
            get { return _XP; }
            set
            {
                g.labelXP.Text = l.GetString("label.xp") + value + " " + l.GetString("other.XPName");
                _XP = value;
            }
        }

        //System values:
        public static string SelectedLang;
        public static bool forceClose = false;
        public static bool forceCloseUseSave = false;
    }
}
