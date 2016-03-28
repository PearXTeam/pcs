using PearXLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace pcs.Player
{
    public class SL
    {
        public static void Load(string filename)
        {
            PCS.l.Add("Loading savefile \"" + filename +"\"...", LogType.Info);
            try
            {
                string[] s = File.ReadAllLines(PCS.PathSaves + filename + ".pcs");
                Stats.MaxFood = Convert.ToInt32(s[0]);
                Stats.MaxHealth = Convert.ToInt32(s[1]);
                Stats.MaxMood = Convert.ToInt32(s[2]);
                Stats.MaxSleep = Convert.ToInt32(s[3]);
                Stats.Food = Convert.ToInt32(s[4]);
                Stats.Health = Convert.ToInt32(s[5]);
                Stats.Mood = Convert.ToInt32(s[6]);
                Stats.Sleep = Convert.ToInt32(s[7]);
                PlayerVals.Money = Convert.ToInt32(s[8]);
                PlayerVals.XP = Convert.ToInt32(s[9]);
            } catch { }
            PCS.l.Add("Done loading savefile.", LogType.Info);
        }

        public static void LoadSettings()
        {
            PCS.l.Add("Loading settings...", LogType.Info);
            try
            {
                string[] s = File.ReadAllLines(PCS.Path + "settings.pcs");
                SettingVals.AutoSave = Convert.ToBoolean(s[0]);
            } catch { }
            PCS.l.Add("Done loading settings...", LogType.Info);
        }

        public static void Save(string filename)
        {
            PCS.l.Add("Saving savefile \"" + filename + "\"...", LogType.Info);
            File.WriteAllLines(PCS.PathSaves + filename + ".pcs", new string[]
            {
                Stats.MaxFood.ToString(),
                Stats.MaxHealth.ToString(),
                Stats.MaxMood.ToString(),
                Stats.MaxSleep.ToString(),
                Stats.Food.ToString(),
                Stats.Health.ToString(),
                Stats.Mood.ToString(),
                Stats.Sleep.ToString(),
                PlayerVals.Money.ToString(),
                PlayerVals.XP.ToString()
            });
            PCS.l.Add("Done saving savefile.", LogType.Info);
        }

        public static void SaveSettings()
        {
            PCS.l.Add("Saving settings...", LogType.Info);
            File.WriteAllLines(PCS.Path + "settings.pcs", new string[]
            {
                SettingVals.AutoSave.ToString()
            });
            PCS.l.Add("Done saving settings.", LogType.Info);
        }
    }
}
