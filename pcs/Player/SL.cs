using PearXLib;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using pcs.Components;

namespace pcs.Player
{
    public class SL
    {
        public static void Load(string filename)
        {
            PCS.l.Add("Loading savefile \"" + filename +"\"...", LogType.Info);

            try
            {
                string s = File.ReadAllText(PCS.PathSaves + filename + ".pcs");
                List<SaveElementStruct> l = JsonConvert.DeserializeObject<List<SaveElementStruct>>(s);
                foreach (SaveElementStruct ses in l)
                {
                    foreach (SaveElement se in Registry.RegisteredSaves)
                    {
                        if (se.Name == ses.Name)
                        {
                            se.Value = ses.Value;
                            se.OnLoaded(se.Name, se.Value);
                            break;
                        }
                    }
                }
                PCS.l.Add("Done loading savefile.", LogType.Info);
            }
            catch(FileNotFoundException e) { PCS.l.Add("Can't load \"" + filename + "\" savefile.", LogType.Error); }
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
           
            List <SaveElementStruct> l = new List<SaveElementStruct>();
            foreach (SaveElement se in Registry.RegisteredSaves)
            {
                se.OnSave(se.Name, out se.Value);
                SaveElementStruct str = new SaveElementStruct();
                str.Value = se.Value;
                str.Name = se.Name;
                l.Add(str);
            }
            File.WriteAllText(PCS.PathSaves + filename + ".pcs", JsonConvert.SerializeObject(l));

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
