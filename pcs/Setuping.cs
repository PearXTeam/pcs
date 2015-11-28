using pcs.Commands;
using pcs.Icons;
using pcs.MiniGames.CatOrDogElements;

namespace pcs
{
    class Setuping
    {
        public static void SetupIcons()
        {
            Registry.RegisterIcon(new IconMiniGames());
            Registry.RegisterMiniIcon(new MiniIconMods());
            Registry.RegisterMiniGameIcon(new IconMGCatOrDog());
            Registry.RegisterMiniIcon(new MiniIconSaveManager());
        }

        public static void SetupCommands()
        {
            Registry.RegisterCommand(new CommandMaxState());
            Registry.RegisterCommand(new CommandSet());
            Registry.RegisterCommand(new CommandDisableStats());
            Registry.RegisterCommand(new CommandHelp());
        }

        public static void SetupCatOrDog()
        {
            Registry.RegisterCatOrDogElement(new CODE_1());
            Registry.RegisterCatOrDogElement(new CODE_2());
            Registry.RegisterCatOrDogElement(new CODE_3());
            Registry.RegisterCatOrDogElement(new CODE_4());
            Registry.RegisterCatOrDogElement(new CODE_5());
            Registry.RegisterCatOrDogElement(new CODE_6());
            Registry.RegisterCatOrDogElement(new CODE_7());
            Registry.RegisterCatOrDogElement(new CODE_8());
            Registry.RegisterCatOrDogElement(new CODE_9());
            Registry.RegisterCatOrDogElement(new CODE_10());
        }
    }
}