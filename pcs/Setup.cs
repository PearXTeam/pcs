using System;
using System.Collections.Generic;
using pcs.Components;
using pcs.Forms;
using pcs.Modding;
using pcs.Player;
using pcs.ToolIcons;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using pcs.Commands;
using pcs.Components.Controls;
using pcs.Components.IAI;
using pcs.Components.Interfaces;
using pcs.Init;
using pcs.Properties;
using PearXLib;

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
            //Tool Icons
            Registry.RegisteredToolIcons.Add(TISettings.ins);
            Registry.RegisteredToolIcons.Add(TIModlist.ins);
            Registry.RegisteredToolIcons.Add(TISaveManager.ins);
            Registry.RegisteredToolIcons.Add(TIAbout.ins);
            Registry.RegisteredToolIcons.Add(TIAchievements.ins);
            Registry.RegisteredToolIcons.Add(TIShare.ins);

            //Achievements
            Registry.RegisteredAchievements.Add(PCSAchievements.Coder);
            Registry.RegisteredAchievements.Add(PCSAchievements.ConsoleDetective);

            //Commands
            Registry.RegisteredCommands.Add(PCSCommands.Restore);
            Registry.RegisteredCommands.Add(PCSCommands.Help);
            Registry.RegisteredCommands.Add(PCSCommands.Set);
            Registry.RegisteredCommands.Add(PCSCommands.Time);
            Registry.RegisteredCommands.Add(PCSCommands.Give);

            //Icons
            Registry.RegisteredIcons.Add(PCSIcons.Inventory);
            Registry.RegisteredIcons.Add(PCSIcons.MiniGames);

            //Items
            Registry.RegisteredItems.Add(PCSItems.Sand);
            Registry.RegisteredItems.Add(PCSItems.BedTalisman);

            //Saves
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

            //Inventory start
            Registry.RegisteredSaves.Add(new SaveElement("PCS_Inventory", (name, value) =>
            {
                List<string[]> l = JsonConvert.DeserializeObject<List<string[]>>(value);
                foreach (string[] s in l)
                {
                    Item itm = Item.FromID(s[0]);
                    if (itm != null)
                    {
                        ItemStack stack = new ItemStack(itm, Convert.ToInt32(s[1]), s[2]);
                        stack.Data = ObjectData.FromString(s[3]);
                        PlayerInventory.Inventory.Add(stack, false);
                    }
                    else
                        PCS.l.Add("Item \"" + s[0] + "\" not exists!", LogType.Error);
                }
            }, (string name, out string value) =>

            {
                List<string[]> l = new List<string[]>();
                foreach (ItemStack s in PlayerInventory.Inventory)
                {
                    l.Add(new string[] {s.Item.ID(), s.StackCount.ToString(), s.SubID, s.Data.ToString()});
                }
                value = JsonConvert.SerializeObject(l);
            }));
            //Inventory end
        }

        public static void SetupTitles()
        {
            Game.instance.Text = PCS.Loc.GetString("title.game") + " Dev " + PCS.Version;

            Options.instance.Text = PCS.Loc.GetString("title.options");
            Modlist.instance.Text = PCS.Loc.GetString("title.modlist");
            SaveManager.instance.Text = PCS.Loc.GetString("title.savemanager");
            GameOver.instance.Text = PCS.Loc.GetString("title.gameover");
            Share.instance.Text = PCS.Loc.GetString("title.share");
            InventoryGUI.Instance.Text = PCS.Loc.GetString("title.minigames");

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

            InventoryGUI.Instance.Text = PCS.Loc.GetString("title.inventory");
        }

        public static void InitToolIcons()
        {
            int count = 0;
            foreach(SToolIcon sti in Registry.RegisteredToolIcons)
            {
                PCSToolIcon xi = new PCSToolIcon();
                xi.Click += sti.OnClick;
                xi.Icon = sti.GetIcon();
                xi.Location = new Point(0, 48 * count);

                ToolTip tip = new ToolTip();
                tip.SetToolTip(xi, sti.Desc());
                tip.InitialDelay = 0;

                Game.instance.panelToolIcons.Controls.Add(xi);
                count++;
            }
        }

        public static void InitIcons()
        {
            int x = 0;
            int y = 0;
            foreach (SIcon i in Registry.RegisteredIcons)
            {
                PCSIcon icn = new PCSIcon();
                icn.Click += i.OnClick;
                icn.Icon = i.GetIcon();
                icn.Title = i.GetName();
                if (x == 5)
                {
                    x = 0;
                    y++;
                }
                icn.Location = new Point(x * icn.Size.Width, y * icn.Size.Height);

                Game.instance.panelIcons.Controls.Add(icn);
                x++;
            }
        }

        public static void InitMiniGames()
        {
            int x = 0;
            int y = 0;
            foreach (SIcon i in Registry.RegisteredMiniGames)
            {
                PCSIcon icn = new PCSIcon();
                icn.Click += i.OnClick;
                icn.Icon = i.GetIcon();
                icn.Title = i.GetName();
                if (x == 3)
                {
                    x = 0;
                    y++;
                }
                icn.Location = new Point(x * icn.Size.Width, y * icn.Size.Height);

                MiniGamesGUI.Instance.panelMg.Controls.Add(icn);
                x++;
            }
        }



        public static void Init()
        {
            Game.instance.panelToolIcons.Size = new Size(48 + SystemInformation.VerticalScrollBarWidth, 344);
            Game.instance.panelIcons.Size = new Size(Game.instance.panelIcons.Width + SystemInformation.VerticalScrollBarWidth, Game.instance.panelIcons.Height);
            MiniGamesGUI.Instance.panelMg.Size = new Size(MiniGamesGUI.Instance.panelMg.Size.Width + SystemInformation.VerticalScrollBarWidth, MiniGamesGUI.Instance.panelMg.Size.Width);

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
            Game.instance.timerTick.Tick += (sender, args) =>
            {
                if (Game.instance.TickNumber == 11)
                    Game.instance.TickNumber = 0;
                foreach (ItemStack s in PlayerInventory.Inventory)
                {
                    ITickable t = s.Item as ITickable;
                    if (t != null)
                    {
                        if (t.IsAsync())
                        {
                            new Thread(() => t.OnTick(s, Game.instance.TickNumber));
                        }
                        else
                            t.OnTick(s, Game.instance.TickNumber);
                    }
                }
                Game.instance.TickNumber++;
            };

            Game.instance.timerFood.Interval = 3600;
            Game.instance.timerMood.Interval = 22000;
            Game.instance.timerSleep.Interval = 3300;
            Game.instance.timerAutosave.Interval = 50000;
            Game.instance.timerTime.Interval = 420;
            Game.instance.timerTick.Interval = 100;

            Game.instance.barFood.GradientColor1 = FlatColors.Pumpkin;
            Game.instance.barFood.GradientColor2 = FlatColors.Pumpkin;
            Game.instance.barHealth.GradientColor1 = FlatColors.Pomegranate;
            Game.instance.barHealth.GradientColor2 = FlatColors.Pomegranate;
            Game.instance.barMood.GradientColor1 = FlatColors.Amethyst;
            Game.instance.barMood.GradientColor2 = FlatColors.Amethyst;
            Game.instance.barSleep.GradientColor1 = FlatColors.WetAsphalt;
            Game.instance.barSleep.GradientColor2 = FlatColors.WetAsphalt;
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
                i++;
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

        public static void PostInit()
        {
            Game.instance.timerTime.Tick += (o, args) =>
            {
                PlayerVals.Time += new TimeSpan(1, 0, 0);
                foreach (var evnt in Registry.RegisteredTimeUpdateEvents)
                {
                    evnt.OnTimeUpdate();
                }
            };
        }

        public static void InitLang(Form form)
        {
            string langPath = PCS.Path + "lang.pcs";
            bool notExists = false;

            if (File.Exists(langPath))
            {
                string s = File.ReadAllText(langPath);
                if (File.Exists(PCS.PathLangs + s + ".lang") && File.Exists(PCS.PathLangs + s + ".langinfo"))
                {
                    PCS.SelectedLang = s;
                    PCS.Loc = new Localization(PCS.PathLangs, PCS.SelectedLang, "ru_RU");
                }
                else
                    notExists = true;
            }
            else
                notExists = true;

            if (notExists)
            {
                form.Invoke(new MethodInvoker(() =>
                {
                    SelectLang sl = new SelectLang();
                    sl.ShowDialog(form);
                }));
                File.WriteAllText(PCS.Path + "lang.pcs", PCS.SelectedLang);
            }
        }
    }
}
