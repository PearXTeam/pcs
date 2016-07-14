using System;
using PearXLib.Engine;

namespace pcs.Core
{
    public class Events
    {
        public static event TimeUpdateEvent TimeUpdate;
        public static event VolumeEventHandler SoundVolumeChanged;
        public static event VolumeEventHandler MusicVolumeChanged;

        public static void OnTimeUpdate(object sender, DateTime dt)
        {
            TimeUpdate?.Invoke(sender, dt);
        }

        public static void OnSoundVolumeChanged(VolumeEventArgs e)
        {
            SoundVolumeChanged?.Invoke(e);
        }

        public static void OnMusicVolumeChanged(VolumeEventArgs e)
        {
            MusicVolumeChanged?.Invoke(e);
        }
    }

    public delegate void TimeUpdateEvent(object sender, DateTime dt);
}
