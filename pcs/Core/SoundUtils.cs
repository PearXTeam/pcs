using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;
using pcs.Components;
using pcs.Player;

namespace pcs.Core
{
    public delegate void VolumeEventHandler(VolumeEventArgs e);

    public class SoundUtils
    {
        public static Dictionary<WaveOut, SoundType> Playing = new Dictionary<WaveOut, SoundType>(); 

        public static void PlaySound(Sound snd)
        {
            MemoryStream stream = new MemoryStream(snd.Data);
            Mp3FileReader reader = new Mp3FileReader(stream);
            WaveOut wo = new WaveOut();

            wo.Init(reader);
            wo.PlaybackStopped += (sender, args) =>
            {
                wo.Dispose();
                reader.Dispose();
                stream.Dispose();
                Playing.Remove(wo);
                GC.Collect();
            };
            wo.Volume = snd.Type == SoundType.Sound ? SettingVals.SoundVolume : SettingVals.MusicVolume;

            Playing.Add(wo, snd.Type);
            wo.Play();
        }
    }

    public class VolumeEventArgs
    {
        public VolumeEventArgs(float val, float valOld)
        {
            Value = val;
            ValueOld = valOld;
        }

        public float ValueOld { get; private set; }
        public float Value { get; private set; }
    }
}
