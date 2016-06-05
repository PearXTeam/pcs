using pcs.Components;
using System.Collections.Generic;
using pcs.Components.IAI;
using pcs.Events;

namespace pcs
{
    public class Registry
    {
        public static List<SToolIcon> RegisteredToolIcons = new List<SToolIcon>();

        public static List<Achievement> RegisteredAchievements = new List<Achievement>();

        public static List<SaveElement> RegisteredSaves = new List<SaveElement>();

        public static List<Command> RegisteredCommands = new List<Command>(); 

        public static List<Item> RegisteredItems = new List<Item>(); 

        public static List<TimeUpdateEvent> RegisteredTimeUpdateEvents = new List<TimeUpdateEvent>(); 
    }
}
