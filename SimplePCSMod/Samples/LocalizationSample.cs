using System;
using System.IO;
using pcs;
using pcs.Modding;
using PearXLib;

namespace SimplePCSMod.Samples
{
    class LocalizationSample : PCSMod
    {
        public Localization modLocalization; //This mod's localization
        public void PreInit()
        {
            Directory.CreateDirectory(PCS.PathLangs + "LocalizationSample"); // Creating dir for mod's localization files

            //The first method of langfile unpacking:
            File.WriteAllLines(PCS.PathLangs + "LocalizationSample/en_US.lang", new string[]
            {
                "log.one=Hello, I'm localized string.",
                "log.two=I'm string №2 =)."
            });

            //The second method of langfile unpacking:
            File.WriteAllBytes(PCS.PathLangs + "LocalizationSample/ru_RU.lang", LocalizationSampleRes.LocalizationSample_ru);
        }
        public void Init()
        {
            modLocalization = new Localization(PCS.PathLangs + "LocalizationSample/", PCS.SelectedLang); //Initing mod's localization.
        }
        public void PostInit()
        {
            PCS.l.Add(modLocalization.GetString("log.one")); //Adding localized string to log.
            PCS.l.Add(modLocalization.GetString("log.two"));
        }






        public string Author()
        {
            return "mrAppleXZ";
        }

        public string ModID()
        {
            return "localization_sample";
        }

        public string Name()
        {
            return "PCS Modding Sample > Localization";
        }

        public string Version()
        {
            return "1";
        }
    }
}
