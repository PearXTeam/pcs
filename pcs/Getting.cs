using pcs.Types;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace pcs
{
    public class Getting
    {
        public static List<Assembly> GetAssemblies()
        {
            List<Assembly> list = new List<Assembly>();
            foreach(Assembly asm in v.asms)
            {
                list.Add(asm);
            }
            list.Add(Assembly.GetExecutingAssembly());
            return list;
        }

        public static string[] GetModNames()
        {
            string[] result = new string[v.asms.Count];
            int count = 0;
            foreach (Assembly asm in v.asms)
            {
                foreach (Type t in asm.GetTypes())
                {
                    if (typeof(PCSMod).IsAssignableFrom(t))
                    {
                        PCSMod pcsm = (PCSMod)Activator.CreateInstance(t);
                        result[count] = pcsm.Name();
                    }
                }
                count++;
            }
            return result;
        }

        public static List<PCSMod> GetMods()
        {
            List<PCSMod> list = new List<PCSMod>();
            foreach(Assembly asm in GetAssemblies())
            {
                foreach(Type t in asm.GetTypes())
                {
                    if(typeof(PCSMod).IsAssignableFrom(t) && t.IsClass)
                    {
                        list.Add((PCSMod)Activator.CreateInstance(t));
                    }
                }
            }
            return list;
        }
    }
}
