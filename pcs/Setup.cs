using pcs.Components;
using pcs.Forms;
using pcs.Modding;
using pcs.Player;
using pcs.ToolIcons;
using PearXLib.Engine;
using System;
using System.Drawing;
using System.Windows.Forms;

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
        }

        public static void Register()
        {
            Registry.RegisteredIcons.Add(TISettings.ins);
            Registry.RegisteredIcons.Add(TIModlist.ins);
        }

        public static void SetupTitles()
        {
            Game.instance.Text = PCS.Loc.GetString("title.game");
            Options.instance.Text = PCS.Loc.GetString("title.options");
            Modlist.instance.Text = PCS.Loc.GetString("title.modlist");
        }

        public static void InitIcons()
        {
            int count = 0;
            foreach(SToolIcon sti in Registry.RegisteredIcons)
            {
                XIcon xi = new XIcon();
                xi.PlaySound = false;
                xi.Expand = 4;
                xi.Size = new Size(40, 40);
                xi.Click += sti.OnClick;
                xi.Icon = sti.GetIcon();
                int shift = 0;
                if (count == 0)
                    shift = 4;
                xi.Location = new Point(4, (48 * count) + shift);
                Game.instance.panelToolIcons.Controls.Add(xi);
                count++;
            }
        }

        public static void Init()
        {
            Game.instance.panelToolIcons.Size = new Size(48 + SystemInformation.VerticalScrollBarWidth, 344);
            Modlist.instance.listViewMods.Columns.Add(PCS.Loc.GetString("modlist.name"), 131);
            Modlist.instance.listViewMods.Columns.Add(PCS.Loc.GetString("modlist.author"), 131);
            Modlist.instance.listViewMods.Columns.Add(PCS.Loc.GetString("modlist.version"), 131);
            Modlist.instance.listViewMods.Columns.Add(PCS.Loc.GetString("modlist.modid"), 131);

            foreach(PCSMod m in ModRegistry.Mods)
            {
                Modlist.instance.listViewMods.Items.Add(new ListViewItem(new string[] { m.Name(), m.Author(), m.Version(), m.ModID()}));
            }
        }
    }
}
