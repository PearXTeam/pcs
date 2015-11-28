using pcs.Properties;
using System.Drawing;

namespace pcs.MiniGames.CatOrDogElements
{
    class CODE_9 : CatOrDogElement
    {
        public CatOrDogType Type() { return CatOrDogType.Dog; }
        public Image Image() { return Resources.Dog_4; }
    }
}
