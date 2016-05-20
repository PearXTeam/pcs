﻿using System;
using pcs.Components;
using pcs.Forms;
using pcs.Modding;
using pcs.Player;
using pcs.ToolIcons;
using PearXLib.Engine;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows.Forms;
using pcs.Commands;
using pcs.Init;
using pcs.Properties;

namespace pcs
{
    class Setup
    {
        public static void SetupDefaults()
        {
            Stats.MaxFood = 100;
            Stats.MaxHealth = 100;
            Stats.MaxMood = 100;
            Stats.MaxSleep = 100;
            Stats.Food = 100;
            Stats.Health = 100;
            Stats.Mood = 100;
            Stats.Sleep = 100;

            PlayerVals.Money = 500;
            PlayerVals.XP = 50;
            PlayerVals.Time = new DateTime(1970, 5, 27, 1, 0, 0);
        }

        public static void Register()
        {
            Registry.RegisteredIcons.Add(TISettings.ins);
            Registry.RegisteredIcons.Add(TIModlist.ins);
            Registry.RegisteredIcons.Add(TISaveManager.ins);
            Registry.RegisteredIcons.Add(TIAbout.ins);
            Registry.RegisteredIcons.Add(TIAchievements.ins);
            Registry.RegisteredIcons.Add(TIShare.ins);


            Registry.RegisteredAchievements.Add(PCSAchievements.Coder);


            Registry.RegisteredCommands.Add(PCSCommands.Restore);
            Registry.RegisteredCommands.Add(PCSCommands.Help);
            Registry.RegisteredCommands.Add(PCSCommands.Set);


            Registry.RegisteredSaves.Add(new SaveElement("PCS_MaxFood", 
                (name, value) => { Stats.MaxFood = Convert.ToInt32(value); }, 
                (string name, out string value) => { value = Stats.MaxFood.ToString(); }));
            Registry.RegisteredSaves.Add(new SaveElement("PCS_MaxHealth",
                (name, value) => { Stats.MaxHealth = Convert.ToInt32(value); },
                (string name, out string value) => { value = Stats.MaxHealth.ToString(); }));
            Registry.RegisteredSaves.Add(new SaveElement("PCS_MaxMood",
                (name, value) => { Stats.MaxMood = Convert.ToInt32(value); },
                (string name, out string value) => { value = Stats.MaxMood.ToString(); }));
            Registry.RegisteredSaves.Add(new SaveElement("PCS_MaxSleep",
                (name, value) => { Stats.MaxSleep = Convert.ToInt32(value); },
                (string name, out string value) => { value = Stats.MaxSleep.ToString(); }));


            Registry.RegisteredSaves.Add(new SaveElement("PCS_Food",
                (name, value) => { Stats.Food = Convert.ToInt32(value); },
                (string name, out string value) => { value = Stats.Food.ToString(); }));
            Registry.RegisteredSaves.Add(new SaveElement("PCS_Health",
                (name, value) => { Stats.Health = Convert.ToInt32(value); },
                (string name, out string value) => { value = Stats.Health.ToString(); }));
            Registry.RegisteredSaves.Add(new SaveElement("PCS_Mood",
                (name, value) => { Stats.Mood = Convert.ToInt32(value); },
                (string name, out string value) => { value = Stats.Mood.ToString(); }));
            Registry.RegisteredSaves.Add(new SaveElement("PCS_Sleep",
                (name, value) => { Stats.Sleep = Convert.ToInt32(value); },
                (string name, out string value) => { value = Stats.Sleep.ToString(); }));

            Registry.RegisteredSaves.Add(new SaveElement("PCS_Money",
                (name, value) => { PlayerVals.Money = BigInteger.Parse(value); },
                (string name, out string value) => { value = PlayerVals.Money.ToString(); }));
            Registry.RegisteredSaves.Add(new SaveElement("PCS_XP",
                (name, value) => { PlayerVals.XP = BigInteger.Parse(value); },
                (string name, out string value) => { value = PlayerVals.XP.ToString(); }));
            Registry.RegisteredSaves.Add(new SaveElement("PCS_Time",
                (name, value) => { PlayerVals.Time = DateTime.FromBinary(Convert.ToInt64(value)); }, 
                (string name, out string value) => { value = PlayerVals.Time.ToBinary().ToString(); }));
        }

        public static void SetupTitles()
        {
            Game.instance.Text = PCS.Loc.GetString("title.game") + " Dev " + PCS.Version;

            Options.instance.Text = PCS.Loc.GetString("title.options");
            Modlist.instance.Text = PCS.Loc.GetString("title.modlist");
            SaveManager.instance.Text = PCS.Loc.GetString("title.savemanager");
            GameOver.instance.Text = PCS.Loc.GetString("title.gameover");
            Share.instance.Text = PCS.Loc.GetString("title.share");

            Options.instance.checkAutosave.Text = PCS.Loc.GetString("options.autosave");
            Options.instance.btnChangeLanguage.Text = PCS.Loc.GetString("options.changeLanguage");

            Modlist.instance.listViewMods.Columns.Add(PCS.Loc.GetString("modlist.name"), 131);
            Modlist.instance.listViewMods.Columns.Add(PCS.Loc.GetString("modlist.author"), 131);
            Modlist.instance.listViewMods.Columns.Add(PCS.Loc.GetString("modlist.version"), 131);
            Modlist.instance.listViewMods.Columns.Add(PCS.Loc.GetString("modlist.modid"), 131);

            SaveManager.instance.buttonSave.Text = PCS.Loc.GetString("savemanager.add");
            SaveManager.instance.buttonReset.Text = PCS.Loc.GetString("savemanager.reset");

            GameOver.instance.lblGameover.Text = PCS.Loc.GetString("gameover.gameover");

            About.instance.Text = PCS.Loc.GetString("title.about");
            About.instance.lblMsg.Text = PCS.Loc.GetString("about.msg");
            About.instance.btnGithub.Text = PCS.Loc.GetString("about.github");
            About.instance.btnWebsite.Text = PCS.Loc.GetString("about.website");
            About.instance.btnDiscord.Text = PCS.Loc.GetString("about.discord");

            AchievementList.instance.Text = PCS.Loc.GetString("title.achievements");

            Share.instance.btnShareVK.Text = PCS.Loc.GetString("share.vk");
            Share.instance.btnShareTwitter.Text = PCS.Loc.GetString("share.twitter");
        }

        public static void InitIcons()
        {
            int count = 0;
            foreach(SToolIcon sti in Registry.RegisteredIcons)
            {
                XIcon xi = new XIcon();
                xi.Expand = 4;
                xi.Size = new Size(48, 48);
                xi.Click += sti.OnClick;
                xi.Icon = sti.GetIcon();
                int shift = 0;
                if (count == 0)
                    shift = 4;
                xi.Location = new Point(0, (48 * count) + shift);

                ToolTip tip = new ToolTip();
                tip.SetToolTip(xi, sti.Desc());
                tip.InitialDelay = 0;

                Game.instance.panelToolIcons.Controls.Add(xi);
                count++;
            }
        }

        public static void Init()
        {
            Game.instance.panelToolIcons.Size = new Size(48 + SystemInformation.VerticalScrollBarWidth, 344);

            foreach(PCSMod m in ModRegistry.Mods)
            {
                Modlist.instance.listViewMods.Items.Add(new ListViewItem(new string[] { m.Name(), m.Author(), m.Version(), m.ModID()}));
            }

            Game.instance.timerFood.Tick += (o, args) => Stats.Food--;
            Game.instance.timerMood.Tick += (o, args) => Stats.Mood--;
            Game.instance.timerSleep.Tick += (o, args) => Stats.Sleep--;
            Game.instance.timerAutosave.Tick += (o, args) =>
            {
                if (SettingVals.AutoSave)
                {
                    SL.Save("autosave");
                }
            };
            Game.instance.timerTime.Tick += (o, args) => PlayerVals.Time += new TimeSpan(0, 1, 0);

            Game.instance.timerFood.Interval = 3600;
            Game.instance.timerMood.Interval = 22000;
            Game.instance.timerSleep.Interval = 3300;
            Game.instance.timerAutosave.Interval = 50000;
            Game.instance.timerTime.Interval = 7;

            
        }

        public static void InitAchievements()
        {
            int i = 0;
            foreach (Achievement ach in Registry.RegisteredAchievements)
            {
                //Control reg:
                AchievementListElement itm = new AchievementListElement();
                itm.Location = new Point(0, 137 * i);
                itm.ItemImage = ach.Icon();
                itm.ItemName = ach.Name();
                itm.ItemDesc = ach.Desc();
                itm.AssociatedAchievement = ach.ID();
                AchievementList.instance.panelAchievements.Controls.Add(itm);

                //Saves reg:
                Registry.RegisteredSaves.Add(new SaveElement("Achievement:" + ach.ID(), 
                    (name, value) => { ach.Unlocked = Convert.ToBoolean(value); },
                    (string name, out string value) => { value = ach.Unlocked.ToString(); }
                    ));
            }
        }

        public static void InitImages()
        {
            Share.instance.btnShareVK.Image = PCSImages.VK;
            Share.instance.btnShareTwitter.Image = PCSImages.Twitter;
        }

        public static void UnpackSounds()
        {
            if (!File.Exists(PCS.PathSounds + "PopUp.mp3"))
            {
                File.WriteAllBytes(PCS.PathSounds + "PopUp.mp3", Resources.PopUp);
            }
        }
    }
}
