using pcs.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs
{
    public class Registry
    {
        public static List<SIcon> RegisteredIcons = new List<SIcon>();
        public static List<SMiniIcon> RegisteredMiniIcons = new List<SMiniIcon>();

        public static void RegisterIcon(SIcon si)
        {
            RegisteredIcons.Add(si);
        }

        public static void RegisterMiniIcon(SMiniIcon si)
        {
            RegisteredMiniIcons.Add(si);
        }
    }
}
