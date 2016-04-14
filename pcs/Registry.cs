using pcs.Components;
using System.Collections.Generic;

namespace pcs
{
    public class Registry
    {
        public static List<SToolIcon> RegisteredIcons = new List<SToolIcon>();

        public static List<Achievement> RegisteredAchievements = new List<Achievement>();

        public static List<SaveElement> RegisteredSaves = new List<SaveElement>();

        public static List<Command> RegisteredCommands = new List<Command>(); 
    }
}
