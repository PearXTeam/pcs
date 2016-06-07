using pcs;
using pcs.Modding;
using System;
using System.Globalization;

namespace SimplePCSMod
{
    class Example : PCSMod
    {
        public string Author()
        {
            return "ExampleCreator";
        }

        public void Init()
        {
            PCS.l.Add("Your .NET version is " + Environment.Version, "EXAMPLE");
        }

        public string ModID()
        {
            return "examplemod";
        }

        public string Name()
        {
            return "Example Mod!";
        }

        public void PostInit()
        {
            PCS.l.Add("You are using \"" + PCS.SelectedLang + "\" language.", "EXAMPLE");
            PCS.l.Add("Your OS language is " + CultureInfo.CurrentCulture.EnglishName, "EXAMPLE");
        }

        public void PreInit()
        {
            PCS.l.Add("I'm PreInited Example Mod ;)", "EXAMPLE");
        }

        public string Version()
        {
            return "1.0.0.0";
        }
    }
}
