using System.Linq;
using pcs.Components;
using pcs.Core;

namespace pcs.Player
{
    public class SettingVals
    {
        private static float _SoundVolume = 1F;
        private static float _MusicVolume = 1F;

        public static bool AutoSave = true;

        public static float SoundVolume
        {
            get { return _SoundVolume; }
            set
            {
                float f = _SoundVolume;
                foreach (var v in SoundUtils.Playing.Where(v => v.Value == SoundType.Sound))
                    v.Key.Volume = value;
                _SoundVolume = value;
                Events.OnSoundVolumeChanged(new VolumeEventArgs(value, f));
            }
        }

        public static float MusicVolume
        {
            get { return _MusicVolume; }
            set
            {
                float f = _MusicVolume;
                foreach (var v in SoundUtils.Playing.Where(v => v.Value == SoundType.Music))
                    v.Key.Volume = value;
                _MusicVolume = value;
                Events.OnMusicVolumeChanged(new VolumeEventArgs(value, f));
            }
        }
    }
}
