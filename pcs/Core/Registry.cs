using pcs.Components;
using System.Collections.Generic;
using pcs.IAI;
namespace pcs.Core
{
    public class Registry
    {
        public static List<SToolIcon> RegisteredToolIcons = new List<SToolIcon>();

        public static List<SIcon> RegisteredIcons = new List<SIcon>();

        public static List<Achievement> RegisteredAchievements = new List<Achievement>();

        public static List<SaveElement> RegisteredSaves = new List<SaveElement>();

        public static List<Command> RegisteredCommands = new List<Command>(); 

        public static List<Item> RegisteredItems = new List<Item>(); 

        public static List<SIcon> RegisteredMiniGames = new List<SIcon>(); 
    }
}
