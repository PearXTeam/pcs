using PearXLib;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;
using pcs.Forms;

namespace pcs.Core
{
    public class PCS
    {

        public static Random Rand = new Random();
        public const string Version = "0.2.0";
        public static Logging l = new Logging(Dirs.Path + "logs/" + PXL.GetDateTimeNow() + ".log");
        public static Localization Loc;
        public static string SelectedLang;
        public static Thread PauseThread;

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
            Mp3FileReader reader = new Mp3FileReader(Dirs.PathSounds + name + ".mp3");
            WaveOut wo = new WaveOut();
            wo.Init(reader);
            wo.Play();
        }

        public static void TakeScreenshot(Control primary)
        {
            Screen s = Screen.FromControl(primary);
            using (Bitmap screen = new Bitmap(s.Bounds.Width, s.Bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(screen))
                {
                    g.CopyFromScreen(s.Bounds.X, s.Bounds.Y, 0, 0, s.Bounds.Size, CopyPixelOperation.SourceCopy);
                }
                screen.Save(Dirs.PathScreenshots + PXL.GetDateTimeNow() + ".png", ImageFormat.Png);
            }
        }
    }
}