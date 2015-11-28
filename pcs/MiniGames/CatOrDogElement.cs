using System.Drawing;

namespace pcs.MiniGames
{
    public interface CatOrDogElement
    {
        CatOrDogType Type();
        Image Image();
    }

    public enum CatOrDogType
    {
        Cat,
        Dog
    }
}
