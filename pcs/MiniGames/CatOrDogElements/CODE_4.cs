using pcs.Properties;
using System.Drawing;

namespace pcs.MiniGames.CatOrDogElements
{
    class CODE_4 : CatOrDogElement
    {
        public CatOrDogType Type() { return CatOrDogType.Cat; }
        public Image Image() { return Resources.Cat_4; }
    }
}
