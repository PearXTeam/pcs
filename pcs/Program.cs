using PearXLib;
using System;
using System.IO;
using System.Windows.Forms;

namespace pcs
{
    /*
    1 minute = 500 ms
    1 hour = 30 s (30000 ms)
    1 day = 12 min (720000 ms)
    */
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            //Pre-initing...
            AppDomain.CurrentDomain.UnhandledException += Crash.OnCrash;

            PCS.l.Add("Starting application...", LogType.Info);

            PCS.l.Add("Creating directories...", LogType.Info);
            Directory.CreateDirectory(PCS.PathCrashes);
            Directory.CreateDirectory(PCS.PathMods);
            Directory.CreateDirectory(PCS.PathLangs);

            Application.Run(Background.instance);
        }
    }
}
