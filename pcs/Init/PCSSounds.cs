using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pcs.Components;
using pcs.Properties;

namespace pcs.Init
{
    public class PCSSounds
    {
        public static Sound PopUp = new Sound {Data = Resources.PopUp, Type = SoundType.Sound};
        public static Sound Eating = new Sound {Data = Resources.Eating, Type = SoundType.Sound};
    }
}
