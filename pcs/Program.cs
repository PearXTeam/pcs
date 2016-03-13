using pcs.Forms;
using pcs.Modding;
using PearXLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

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
