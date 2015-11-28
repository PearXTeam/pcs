using System;
using PearXLib;
using System.Numerics;

namespace pcs
{
    public class a
    {
        public static void Load(string savename)
        {
            try
            {
                string[] s = FileUtils.LoadEnc("PCSimulator", savename, 12, false);
                v.Food = Convert.ToInt16(s[0]);
                v.Mood = Convert.ToInt16(s[1]);
                v.Sleep = Convert.ToInt16(s[2]);
                v.Purity = Convert.ToInt16(s[3]);
                v.Health = Convert.ToInt16(s[4]);
                v.Money = BigInteger.Parse(s[5]);
                v.XP = BigInteger.Parse(s[6]);
                v.CatOrDogHighScore = BigInteger.Parse(s[7]);
            }
            catch { }
        }

        public static void Save(string savename)
        {
            FileUtils.SaveEnc("PCSimulator", savename, new string[]
                {
                    v.Food.ToString(),
                    v.Mood.ToString(),
                    v.Sleep.ToString(),
                    v.Purity.ToString(),
                    v.Health.ToString(),
                    v.Money.ToString(),
                    v.XP.ToString(),
                    v.CatOrDogHighScore.ToString()
                }, 12, false);
        }

        public static void Kill(KilledBy kb)
        {
            v.g.timerFood.Stop();
            v.g.timerMood.Stop();
            v.g.timerPurity.Stop();
            v.g.timerSleep.Stop();
            Death d = new Death(kb);
            d.ShowDialog();
        }

        public static void prepareGame()
        {
            v.g.barFood.Value = v.Food;
            v.g.barFood.ProgressText = v.l.GetString("bar.food") + v.Food.ToString() + "%";

            v.g.barMood.Value = v.Mood;
            v.g.barMood.ProgressText = v.l.GetString("bar.mood") + v.Mood.ToString() + "%";

            v.g.barSleep.Value = v.Sleep;
            v.g.barSleep.ProgressText = v.l.GetString("bar.sleep") + v.Sleep.ToString() + "%";

            v.g.barPurity.Value = v.Purity;
            v.g.barPurity.ProgressText = v.l.GetString("bar.purity") + v.Purity.ToString() + "%";

            v.g.barHealth.Value = v.Health;
            v.g.barHealth.ProgressText = v.l.GetString("bar.health") + v.Health.ToString() + "%";

            v.g.labelMoneys.Text = v.l.GetString("label.moneys") + v.Money + " " + v.l.GetString("other.currency");
            v.g.labelXP.Text = v.l.GetString("label.xp") + v.XP + " " + v.l.GetString("other.XPName");

            Setuping.SetupIcons();
            Setuping.SetupCommands();
            Setuping.SetupCatOrDog();

            v.Log.LogChanged += Log_LogChanged;
        }

        public static void AutoSave()
        {
            Save("auto");
        }

        public static void AutoLoad()
        {
            Load("auto");
        }





        private static void Log_LogChanged(object sender, EventArgs e)
        {
            if (v.c != null)
            {
                v.c.labelChat.Text = v.Log.Log;
                v.c.Upd();
            }
        }
    }
}
