using PearXLib;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using pcs.Components;
using pcs.Components.Controls;
using pcs.Core;
using pcs.Forms;
using pcs.Init;
using PearXLib.Engine.Flat;
using System.Windows.Forms;

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

                int i = 0;
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

                    i++;
                }
                PCS.l.Add("Done loading save.", LogType.Info);
            }
            catch(FileNotFoundException) { PCS.l.Add("Can't load \"" + filename + "\" save.", LogType.Error); }
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
    }
}
