using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace pcs.Modding
{
    public class ModRegistry
    {
        public static List<Assembly> Assemblies = new List<Assembly>();
        public static List<PCSMod> Mods = new List<PCSMod>();
    }
}
