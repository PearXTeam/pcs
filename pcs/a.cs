using System;
using PearXLib;
using System.Numerics;
using System.Windows.Forms;

namespace pcs
{
    public class a
    {
        public static void Load(string savename)
        {
            try
            {
                string[] s = FileUtils.LoadEnc("PCSimulator", "saves" + PXL.s + savename, 12, false);
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
            if (FileUtils.CanCreate(savename))
            {
                FileUtils.SaveEnc("PCSimulator", "saves" + PXL.s + savename, new string[]
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
            else
            {
                MessageBox.Show(v.l.GetString("savemanager.cannotSave.text"), v.l.GetString("savemanager.cannotSave.title"));
            }
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
