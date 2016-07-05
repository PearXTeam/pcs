
using PearXLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using pcs.Player;

namespace pcs.Core
{
    public class Crash
    {
        public delegate void CrashHandler(object sender, Exception e, ref List<string> toReturn);
        public static event CrashHandler GetAnotherCrashInfo;

        public static void PerformCrash(string msg)
        {
            throw new Exception(msg);
        }

        public static void OnCrash(object sender, Exception e)
        {
            PCS.l.Add(e.ToString(), LogType.Error);

            StringBuilder sb = new StringBuilder();

            //Splash generation:
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            sb.AppendLine("==A PCS crash-report==");
            sb.AppendLine("//" + Splashes.GenCrashSplash());
            sb.AppendLine("Crash date and time: " + DateTime.Now);
            sb.AppendLine("________________________");
            sb.AppendLine(e.ToString());
            sb.AppendLine("________________________");
            sb.AppendLine("=====System Details=====");
            sb.AppendLine("OS Version: " + Environment.OSVersion);
            sb.AppendLine(".NET Version: " + Environment.Version);
            sb.AppendLine("Available RAM: " + PCUtils.GetFromPC("FreePhysicalMemory") + " KB (" + Convert.ToInt64(PCUtils.GetFromPC("FreePhysicalMemory")) / 1024 + " MB)");
            sb.AppendLine("Total RAM: " + PCUtils.GetFromPC("TotalVisibleMemorySize") + " KB (" + Convert.ToInt64(PCUtils.GetFromPC("TotalVisibleMemorySize")) / 1024 + " MB)");
            sb.AppendLine("Used RAM: " + GC.GetTotalMemory(true) + " B (" + GC.GetTotalMemory(true) / 1024 + " KB)");
            string s = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            sb.AppendLine("OS Caption: " + PCUtils.GetFromPC("Caption") + " (" + s + ")");
            sb.AppendLine("Game Path: " + Dirs.Path);
            sb.AppendLine("OS Language: " + CultureInfo.InstalledUICulture.EnglishName);
            sb.AppendLine("_______________________");
            List<string> l = new List<string>();
            try
            {
                GetAnotherCrashInfo(sender, e, ref l);
                foreach(string str in l)
                {
                    sb.AppendLine(str);
                }
            } catch { }
            File.WriteAllText(Dirs.PathCrashes + "crash_" + PXL.GetDateTimeNow() + ".txt", sb.ToString());

            SL.Save("autosave");

            Environment.Exit(0);
        }
    }
}
