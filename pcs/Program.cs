using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PearXLib.Forms;
using System.IO;
using PearXLib;
using pcs.Properties;
using System.Reflection;
using pcs.Modding;

namespace pcs
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.EnableVisualStyles();

            v.Log.Add("Starting application...", LogType.Info);

            string pathToLangs = v.PathToDir + "langs" + PXL.s;
            string pathToPlugins = v.PathToDir + "plugins" + PXL.s;
            
            FileUtils.createDir(pathToLangs);
            FileUtils.createDir(pathToPlugins);

            #region Language init.

            v.Log.Add("Initializing languages...", LogType.Info);

            File.WriteAllBytes(pathToLangs + "ru_RU.lang", Resources.ru_RU);
            File.WriteAllBytes(pathToLangs + "en_US.lang", Resources.en_US);
            File.WriteAllBytes(pathToLangs + "ru_RU.langinfo", Resources.ru_RU_info);
            File.WriteAllBytes(pathToLangs + "en_US.langinfo", Resources.en_US_info);

            if (File.Exists(v.PathToDir + "lang.save"))
            {
                if (File.Exists(pathToLangs + File.ReadAllText(v.PathToDir + "lang.save") + ".lang") && File.Exists(pathToLangs + File.ReadAllText(v.PathToDir + "lang.save") + ".langinfo"))
                {
                    v.SelectedLang = File.ReadAllText(v.PathToDir + "lang.save");
                }
                else
                {
                    SelectLang sl = new SelectLang("PCSimulator");
                    sl.ShowDialog();
                    v.SelectedLang = sl.Selected;
                    File.WriteAllText(v.PathToDir + "lang.save", v.SelectedLang);
                }
            }
            else
            {
                SelectLang sl = new SelectLang("PCSimulator");
                sl.ShowDialog();
                v.SelectedLang = sl.Selected;
                File.WriteAllText(v.PathToDir + "lang.save", v.SelectedLang);
            }
            v.l = new Localization("PCSimulator", v.SelectedLang);
            #endregion

            #region Mods init.
            v.Log.Add("Initializing mods...", LogType.Info);
            foreach (string s in Directory.GetFiles(pathToPlugins)) // Mods initialization.
            {
                Assembly asm = null;
                try
                {
                    asm = Assembly.LoadFrom(s);
                }
                catch { }
                if (asm != null)
                {
                    foreach(Type t in asm.GetTypes())
                    {
                        if (typeof(PCSMod).IsAssignableFrom(t))
                        {
                            v.asms.Add(asm);
                        }
                    }
                }
            }
            #endregion

            Application.Run(v.g);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            
        }
    }
}
