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

        public static void RegisterIcon(SIcon si)
        {
            RegisteredIcons.Add(si);
        }
    }
}
