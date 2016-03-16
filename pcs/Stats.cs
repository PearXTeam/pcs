using pcs.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs
{
    public class Stats
    {
        private static int maxfood = 100;
        private static int maxhealth = 100;
        private static int maxmood = 100;
        private static int maxsleep = 100;

        private static int food = 100;
        private static int health = 100;
        private static int mood = 100;
        private static int sleep = 100;

        public static int MaxFood
        {
            get
            {
                return maxfood;
            }
            set
            {
                if(value < 1)
                {
                    value = 1;
                }
                maxfood = value;
                if (Food > value)
                {
                    Food = value;
                }
                Game.instance.barFood.Maximum = value;
                Game.instance.barFood.ProgressText = PCS.Loc.GetString("bar.food") + Food + "/" + value;
            }
        }

        public static int MaxHealth
        {
            get
            {
                return maxhealth;
            }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                maxhealth = value;
                if (Health > value)
                {
                    Health = value;
                }
                Game.instance.barHealth.Maximum = value;
                Game.instance.barHealth.ProgressText = PCS.Loc.GetString("bar.health") + Health + "/" + value;
            }
        }

        public static int MaxMood
        {
            get
            {
                return maxmood;
            }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                maxmood = value;
                if (Mood > value)
                {
                    Mood = value;
                }
                Game.instance.barMood.Maximum = value;
                Game.instance.barMood.ProgressText = PCS.Loc.GetString("bar.mood") + Mood + "/" + value;
            }
        }

        public static int MaxSleep
        {
            get
            {
                return maxsleep;
            }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                maxsleep = value;
                if (Sleep > value)
                {
                    Sleep = value;
                }
                Game.instance.barSleep.Maximum = value;
                Game.instance.barSleep.ProgressText = PCS.Loc.GetString("bar.sleep") + Sleep + "/" + value;
            }
        }

        public static int Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
                
            }
        }

        //Todo: \/
        public static int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
                
            }
        }

        public static int Mood
        {
            get
            {
                return mood;
            }
            set
            {
                mood = value;
                
            }
        }

        public static int Sleep
        {
            get
            {
                return sleep;
            }
            set
            {
                sleep = value;
                
            }
        }
    }
}
