using PearXLib;
using System;
using System.IO;
using System.Windows.Forms;
using pcs.Core;

namespace pcs
{
    /*
    1 minute = 250 ms
    1 hour = 15 s (15.000 ms)
    1 day = 6 min (360.000 ms)
    */
    static class Program
    {
        /// <summary>
        /// Enter \/
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Pre-initing...
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => { Crash.OnCrash(sender, (Exception)args.ExceptionObject); };
            Application.ThreadException += (sender, args) => {Crash.OnCrash(sender, args.Exception);};

            PCS.l.Add("Starting application...", LogType.Info);

            PCS.l.Add("Creating directories...", LogType.Info);
            Directory.CreateDirectory(Dirs.PathCrashes);
            Directory.CreateDirectory(Dirs.PathMods);
            Directory.CreateDirectory(Dirs.PathLangs);
            Directory.CreateDirectory(Dirs.PathSaves);
            Directory.CreateDirectory(Dirs.PathSounds);

            Application.Run(Background.instance);
        }
    }
}
