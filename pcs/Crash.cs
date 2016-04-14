
using PearXLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace pcs
{
    public class Crash
    {
        public delegate void CrashHandler(object sender, UnhandledExceptionEventArgs e, ref List<string> toReturn);
        public static event CrashHandler GetAnotherCrashInfo;

        public static void PerformCrash(string msg)
        {
            throw new Exception(msg);
        }

        public static void OnCrash(object sender, UnhandledExceptionEventArgs e)
        {
            PCS.l.Add(e.ExceptionObject.ToString(), LogType.Error);

            StringBuilder sb = new StringBuilder();

            //Splash generation:
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            sb.AppendLine("==A PCSim crash-report==");
            sb.AppendLine("//" + Splashes.GenCrashSplash());
            sb.AppendLine("Crash date and time: " + DateTime.Now);
            sb.AppendLine("________________________");
            sb.AppendLine(e.ExceptionObject.ToString());
            sb.AppendLine("________________________");
            sb.AppendLine("=====System Detalis=====");
            sb.AppendLine("OS Version: " + Environment.OSVersion);
            sb.AppendLine(".NET Version: " + Environment.Version);
            sb.AppendLine("Avaible RAM: " + PXL.GetFromPC("FreePhysicalMemory") + " KB (" + Convert.ToInt64(PXL.GetFromPC("FreePhysicalMemory")) / 1024 + " MB)");
            sb.AppendLine("Total RAM: " + PXL.GetFromPC("TotalVisibleMemorySize") + " KB (" + Convert.ToInt64(PXL.GetFromPC("TotalVisibleMemorySize")) / 1024 + " MB)");
            sb.AppendLine("Used RAM: " + GC.GetTotalMemory(true) + " B (" + GC.GetTotalMemory(true) / 1024 + " KB)");
            string s = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            sb.AppendLine("OS Caption: " + PXL.GetFromPC("Caption") + " (" + s + ")");
            sb.AppendLine("Game Path: " + PCS.Path);
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
            File.WriteAllText(PCS.PathCrashes + "crash_" + PXL.GetDateTimeNow() + ".txt", sb.ToString());
            Environment.Exit(0);
        }
    }
}
