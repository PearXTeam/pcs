

namespace pcs.Components
{
    public class Sound
    {
        /// <summary>
        /// Raw MP3 sound data.
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Type of the sound.
        /// </summary>
        public SoundType Type { get; set; }
    }

    public enum SoundType
    {
        Music,
        Sound
    }
}
