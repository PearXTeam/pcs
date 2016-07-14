using System;
using PearXLib.Engine;

namespace pcs.Core
{
    public class Events
    {
        public static event TimeUpdateEvent TimeUpdate;
        public static event BarEventHandler SoundVolumeChanged;
        public static event BarEventHandler MusicVolumeChanged;

        public static void OnTimeUpdate(object sender, DateTime dt)
        {
            TimeUpdate?.Invoke(sender, dt);
        }

        public static void OnSoundVolumeChanged(object sender, BarEventArgs e)
        {
            SoundVolumeChanged?.Invoke(sender, e);
        }

        public static void OnMusicVolumeChanged(object sender, BarEventArgs e)
        {
            MusicVolumeChanged?.Invoke(sender, e);
        }
    }

    public delegate void TimeUpdateEvent(object sender, DateTime dt);
}
