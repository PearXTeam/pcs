using PearXLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pcs.Forms;

namespace pcs
{
    public class PCS
    {
        public static Random Rand = new Random();
        public static string Path = d.pxDir + "/PCS/";
        public static string PathCrashes = Path + "crash-reports/";
        public static string PathMods = Path + "mods/";
        public static string PathLangs = Path + "lang/";
        public static string PathSaves = Path + "saves/";

        public static Logging l = new Logging(Path + "logs/" + PXL.GetDateTimeNow() + ".log");
        public static Localization Loc;
        public static string SelectedLang;

        public static Point PreviousLocation = new Point((Screen.PrimaryScreen.WorkingArea.Width - 768) / 2, (Screen.PrimaryScreen.WorkingArea.Height - 512) / 2);

        public static void Restart()
        {
            Game.instance.DontSave = true;
            Process.Start("pcs.exe");
            Game.instance.Close();
        }
    }
}
