using pcs.MiniGames;
using pcs.Types;
using System.Collections.Generic;

namespace pcs
{
    public class Registry
    {
        public static List<SIcon> RegisteredIcons = new List<SIcon>();
        public static List<SMiniIcon> RegisteredMiniIcons = new List<SMiniIcon>();
        public static List<SCommand> RegisteredCommands = new List<SCommand>();
        public static List<SIcon> RegisteredMiniGameIcons = new List<SIcon>();
        public static List<CatOrDogElement> RegisteredCatOrDogElements = new List<CatOrDogElement>();

        public static void RegisterIcon(SIcon si)
        {
            RegisteredIcons.Add(si);
        }

        public static void RegisterMiniIcon(SMiniIcon si)
        {
            RegisteredMiniIcons.Add(si);
        }

        public static void RegisterCommand(SCommand sc)
        {
            RegisteredCommands.Add(sc);
        }

        public static void RegisterMiniGameIcon(SIcon si)
        {
            RegisteredMiniGameIcons.Add(si);
        }

        public static void RegisterCatOrDogElement(CatOrDogElement code)
        {
            RegisteredCatOrDogElements.Add(code);
        }
    }
}
