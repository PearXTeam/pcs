using PearXLib;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using pcs.Components;
using pcs.Core;
using pcs.Init;

namespace pcs.Player
{
    public class SL
    {
        public static void Load(string filename)
        {
            PCS.l.Add("Loading save \"" + filename +"\"...", LogType.Info);

            try
            {
                string s = File.ReadAllText(Dirs.PathSaves + filename + ".pcs");
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
                PCS.l.Add("Done loading save.", LogType.Info);
            }
            catch(FileNotFoundException) { PCS.l.Add("Can't load \"" + filename + "\" save.", LogType.Error); }
        }

        public static void LoadSettings()
        {
            PCS.l.Add("Loading settings...", LogType.Info);
            try
            {
                string[] s = File.ReadAllLines(Dirs.Path + "settings.pcs");
                SettingVals.AutoSave = Convert.ToBoolean(s[0]);
            } catch { }
            PCS.l.Add("Done loading settings...", LogType.Info);
        }

        public static void Save(string filename)
        {
            if (FileUtils.CanCreate(filename))
            {
                PCS.l.Add("Saving save \"" + filename + "\"...", LogType.Info);

                List<SaveElementStruct> l = new List<SaveElementStruct>();
                foreach (SaveElement se in Registry.RegisteredSaves)
                {
                    se.OnSave(se.Name, out se.Value);
                    SaveElementStruct str = new SaveElementStruct
                    {
                        Value = se.Value,
                        Name = se.Name
                    };
                    l.Add(str);
                }
                File.WriteAllText(Dirs.PathSaves + filename + ".pcs", JsonConvert.SerializeObject(l, Formatting.Indented));

                PCS.l.Add("Done saving save.", LogType.Info);
            }
            else
            {
                new PopUp().Display(PCS.Loc.GetString("savemanager.saveError"), PCS.Loc.GetString("savemanager.saveError.message").Replace("{filename}", filename), PCSImages.BrokenFloppy);
            }
        }

        public static void SaveSettings()
        {
            PCS.l.Add("Saving settings...", LogType.Info);
            File.WriteAllLines(Dirs.Path + "settings.pcs", new string[]
            {
                SettingVals.AutoSave.ToString()
            });
            PCS.l.Add("Done saving settings.", LogType.Info);
        }

        //_____
    }
}
