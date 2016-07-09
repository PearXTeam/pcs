using pcs.Core;
using pcs.Forms;

namespace pcs.Player
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
                Game.instance.barFood.Text = PCS.Loc.GetString("bar.food") + Food + "/" + value;
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
                Game.instance.barHealth.Text = PCS.Loc.GetString("bar.health") + Health + "/" + value;
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
                Game.instance.barMood.Text = PCS.Loc.GetString("bar.mood") + Mood + "/" + value;
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
                Game.instance.barSleep.Text = PCS.Loc.GetString("bar.sleep") + Sleep + "/" + value;
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
                if (value <= 0)
                {
                    GameOver.instance.Kill(DeadBy.Hunger);
                }
                if (value > MaxFood)
                {
                    value = MaxFood;
                }
                food = value;
                Game.instance.barFood.Value = value;
                Game.instance.barFood.Text = PCS.Loc.GetString("bar.food") + value + "/" + MaxFood;
            }
        }

        public static int Health
        {
            get
            {
                return health;
            }
            set
            {
                if(value <= 0)
                {
                    GameOver.instance.Kill(DeadBy.Illness);
                }
                if(value > MaxHealth)
                {
                    value = MaxHealth;
                }
                health = value;
                Game.instance.barHealth.Value = value;
                Game.instance.barHealth.Text = PCS.Loc.GetString("bar.health") + value + "/" + MaxHealth;
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
                if (value <= 0)
                {
                    GameOver.instance.Kill(DeadBy.Bore);
                }
                if (value > MaxMood)
                {
                    value = MaxMood;
                }
                mood = value;
                Game.instance.barMood.Value = value;
                Game.instance.barMood.Text = PCS.Loc.GetString("bar.mood") + value + "/" + MaxMood;
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
                if (value <= 0)
                {
                    GameOver.instance.Kill(DeadBy.LackOfSleep);
                }
                if (value > MaxSleep)
                {
                    value = MaxSleep;
                }
                sleep = value;
                Game.instance.barSleep.Value = value;
                Game.instance.barSleep.Text = PCS.Loc.GetString("bar.sleep") + value + "/" + MaxSleep;
            }
        }
    }
}
