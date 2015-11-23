using pcs.Commands;
using pcs.Icons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs
{
    class Setuping
    {
        public static void SetupIcons()
        {
            Registry.RegisterIcon(new IconMiniGames());
            Registry.RegisterMiniIcon(new MiniIconMods());
        }

        public static void SetupCommands()
        {
            Registry.RegisterCommand(new CommandMaxState());
            Registry.RegisterCommand(new CommandSet());
        }
    }
}