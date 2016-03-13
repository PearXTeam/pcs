using PearXLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pcs
{
    public class PCS
    {
        public static Random Rand = new Random();
        public static string Path = d.pxDir + "/PCS/";
        public static string PathCrashes = Path + "crash-reports/";
        public static string PathMods = Path + "mods/";
        public static string PathLangs = Path + "lang/";
        public static Logging l = new Logging(Path + "logs/" + PXL.GetDateTimeNow() + ".log");

        public static Point PreviousLocation = new Point(0, 0);
    }
}
