using PearXLib;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
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
        public static string PathSounds = Path + "sounds/";
        public const string Version = "0.0.2";

        public static Logging l = new Logging(Path + "logs/" + PXL.GetDateTimeNow() + ".log");
        public static Localization Loc;
        public static string SelectedLang;

        public static Point PreviousLocation = new Point((Screen.PrimaryScreen.WorkingArea.Width - 768)/2,
            (Screen.PrimaryScreen.WorkingArea.Height - 512)/2);

        public static void Restart(bool save)
        {
            Game.instance.DontSave = !save;
            Process.Start("pcs.exe");
            Game.instance.Close();
        }

        public static void PlaySound(string name)
        {
            Mp3FileReader reader = new Mp3FileReader(PCS.PathSounds + name + ".mp3");
            WaveOut wo = new WaveOut();
            wo.Init(reader);
            wo.Play();
        }
    }
}