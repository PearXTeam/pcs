﻿using pcs.Properties;
using System.Drawing;

namespace pcs.MiniGames.CatOrDogElements
{
    class CODE_5 : CatOrDogElement
    {
        public CatOrDogType Type() { return CatOrDogType.Cat; }
        public Image Image() { return Resources.Cat_5; }
    }
}
