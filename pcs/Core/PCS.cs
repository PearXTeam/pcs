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
        public const string Version = "0.4.0";
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

        public static void TakeScreenshot(Control primary, bool full)
        {
            if (full)
            {
                Screen screen = Screen.FromControl(primary);
                using (Bitmap bmp = new Bitmap(screen.Bounds.Width, screen.Bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size, CopyPixelOperation.SourceCopy);
                    }
                    bmp.Save(Dirs.PathScreenshots + PXL.GetDateTimeNow() + ".png", ImageFormat.Png);
                }
            }
            else
            {
                using (Bitmap bmp = new Bitmap(primary.Width, primary.Height))
                {
                    primary.DrawToBitmap(bmp, new Rectangle(0, 0, primary.Width, primary.Height));
                    bmp.Save(Dirs.PathScreenshots + PXL.GetDateTimeNow() + ".png", ImageFormat.Png);
                }
            }
        }
    }
}