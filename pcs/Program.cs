using System;
using System.Windows.Forms;
using PearXLib.Forms;
using System.IO;
using PearXLib;
using pcs.Properties;
using System.Reflection;
using System.Text;
using pcs.Types;
using pcs.EmbeddedLangs;

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
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();

            v.Log.Add("Starting application...", LogType.Info);
            string pathToLangs = v.PathToDir + "langs" + PXL.s;
            string pathToPlugins = v.PathToDir + "plugins" + PXL.s;
            
            FileUtils.createDir(pathToLangs);
            FileUtils.createDir(pathToPlugins);
            FileUtils.createDir(v.PathToDir + "crashes");
            FileUtils.createDir(v.PathToDir + "saves");

            #region Language init.

            v.Log.Add("Initializing languages...", LogType.Info);

            File.WriteAllBytes(pathToLangs + "ru_RU.lang", EmbLangs.ru_RU);
            File.WriteAllBytes(pathToLangs + "en_US.lang", EmbLangs.en_US);
            File.WriteAllBytes(pathToLangs + "ru_RU.langinfo", EmbLangs.ru_RU_info);
            File.WriteAllBytes(pathToLangs + "en_US.langinfo", EmbLangs.en_US_info);

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

        private static void Crush(string str)
        {
            v.Log.Add("Game crushed! Please report a crush information!", LogType.Error);


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-- PCSimulator Crash Report. --");
            sb.AppendLine("// I'm sorry!");
            sb.AppendLine("");
            sb.AppendLine("Time of crash: " + DateTime.Now);
            sb.AppendLine("");
            sb.AppendLine(str);
            sb.AppendLine("");
            sb.AppendLine("_______________");
            sb.AppendLine("Game version: " + v.Version);
            sb.AppendLine("OS version: " + Environment.OSVersion);
            sb.AppendLine("Is 64-bit OS: " + Environment.Is64BitOperatingSystem);
            sb.AppendLine("Framework: " + Environment.Version);
            if (Getting.GetMods() != null)
            {
                sb.AppendLine("_______________");
                sb.AppendLine("Installed mods:");
                foreach(PCSMod pcsm in Getting.GetMods())
                {
                    sb.AppendLine(pcsm.Name() + " | " + pcsm.Version());
                }
            }

            File.WriteAllText(v.PathToDir + "crashes" + PXL.s + PXL.GetDateTimeNow() + "_crash.txt", sb.ToString());
            v.forceClose = true;
            v.forceCloseUseSave = true;
            Application.Exit();
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Crush(e.Exception.ToString());
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Crush(e.ExceptionObject.ToString());
        }
    }
}
