using pcs.Modding;
using PearXLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace pcs.Forms
{
    public partial class Loading : PCSForm, IMain
    {
        public static Loading instance = new Loading();
        
        public Loading()
        {
            InitializeComponent();
            Text = "Loading...";
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.Sleep(300);
                SetMax(1, 5);
                //
                //
                SetVal(1, 0);
                SetText(1, "Loading mods...");
                PCS.l.Add("Loading mods...", LogType.Info);
                foreach (string s in Directory.GetFiles(PCS.PathMods))
                {
                    Assembly asm = null;
                    try { asm = Assembly.LoadFrom(s); } catch { }
                    if (asm != null)
                    {
                        PCS.l.Add("Founded \"" + Path.GetFileName(s) + "\" assembly.", LogType.Info);
                        ModRegistry.Assemblies.Add(asm);
                        foreach (Type t in asm.GetTypes())
                        {
                            if (typeof(PCSMod).IsAssignableFrom(t) && t.IsClass)
                            {
                                PCS.l.Add("Added \"" + t.FullName + "\" to mods.", LogType.Info);
                                ModRegistry.Mods.Add((PCSMod)Activator.CreateInstance(t));
                            }
                        }
                    }
                }
                //
                //
                SetVal(1, 1);
                SetText(1, "PreIniting mods...");
                PCS.l.Add("Performing PreInit from mods...", LogType.Info);
                SetMax(2, ModRegistry.Mods.Count);
                foreach (PCSMod m in ModRegistry.Mods)
                {
                    SetVal(2, bar2.Value + 1);
                    SetText(2, "PreIniting " + m.Name());
                    PCS.l.Add("PreIniting \"" + m.ModID() + "\"", LogType.Info);
                    m.PreInit();
                }
                SetText(2, "");
                SetVal(2, 0);
                //
                //
                SetVal(1, 2);
                SetText(1, "Initing game...");
                SetMax(2, 4);

                SetVal(2, 0);
                SetText(2, "Unpacking default langs...");
                File.WriteAllBytes(PCS.PathLangs + "ru_RU.lang", EmbLangs.EmbLangs.ru_RU);
                File.WriteAllBytes(PCS.PathLangs + "ru_RU.langinfo", EmbLangs.EmbLangs.ru_RU_inf);

                SetVal(2, 1);
                SetText(2, "Selecting lang...");
                string langpath = PCS.Path + "lang.pcs";
                bool notex = false;
                if (File.Exists(langpath))
                {
                    string s = File.ReadAllText(langpath);
                    if (File.Exists(PCS.PathLangs + s + ".lang") && File.Exists(PCS.PathLangs + s + ".langinfo"))
                    {
                        PCS.SelectedLang = s;
                        PCS.Loc = new Localization(PCS.PathLangs, PCS.SelectedLang);
                    }
                    else
                        notex = true;
                }
                else
                    notex = true;
                if(notex)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        SelectLang sl = new SelectLang();
                        sl.ShowDialog(this);
                    }));
                    File.WriteAllText(PCS.Path + "lang.pcs", PCS.SelectedLang);
                }

                SetVal(2, 2);
                SetText(2, "Setuping titles...");
                Game.instance.Text = PCS.Loc.GetString("title.game");

                SetVal(2, 3);
                SetText(2, "Setting up stats...");
                Stats.MaxFood = 100;
                Stats.MaxHealth = 100;
                Stats.MaxMood = 100;
                Stats.MaxSleep = 100;
                Stats.Food = 100;
                Stats.Health = 100;
                Stats.Mood = 100;
                Stats.Sleep = 100;

                SetVal(2, 4);
                SetVal(2, 0);
                SetText(2, "");
                //
                //
                SetVal(1, 3);
                SetText(1, "Initing mods...");
                PCS.l.Add("Performing Init from mods...", LogType.Info);
                SetMax(2, ModRegistry.Mods.Count);
                foreach (PCSMod m in ModRegistry.Mods)
                {
                    SetVal(2, bar2.Value + 1);
                    SetText(2, "Initing " + m.Name());
                    PCS.l.Add("Initing \"" + m.ModID() + "\"", LogType.Info);
                    m.Init();
                }
                SetText(2, "");
                SetVal(2, 0);
                //
                //
                SetVal(1, 4);
                SetText(1, "PostIniting mods...");
                PCS.l.Add("Performing PostInit from mods...", LogType.Info);
                SetMax(2, ModRegistry.Mods.Count);
                foreach (PCSMod m in ModRegistry.Mods)
                {
                    SetVal(2, bar2.Value + 1);
                    SetText(2, "PostIniting " + m.Name());
                    PCS.l.Add("PostIniting \"" + m.ModID() + "\"", LogType.Info);
                    m.PostInit();
                }
                SetText(2, "");
                SetVal(2, 0);
                //
                //
                SetVal(1, 5);
                SetText(1, "Done");
                //
                //
                Invoke(new MethodInvoker(() =>
                {
                    ShowNew(Game.instance);
                }));
            }).Start();
        }

        public void SetText(short label, string text)
        {
            try
            {
                Invoke(new MethodInvoker(() =>
                {
                    if (label == 1)
                    {
                        lbl1.Text = text;
                        lbl1.Location = new Point((Width - lbl1.Width) / 2, lbl1.Location.Y);
                    }
                    else if (label == 2)
                    {
                        lbl2.Text = text;
                        lbl2.Location = new Point((Width - lbl2.Width) / 2, lbl2.Location.Y);
                    }
                }));
            }
            catch { }
        }

        public void SetVal(short bar, int val)
        {
            try
            {
                Invoke(new MethodInvoker(() =>
                {
                    if (bar == 1)
                    {
                        bar1.Value = val;
                    }
                    else if (bar == 2)
                    {
                        bar2.Value = val;
                    }
                }));
            }
            catch { }
        }

        public void SetMax(short bar, int max)
        {
            try
            {
                Invoke(new MethodInvoker(() =>
                {
                    if (bar == 1)
                    {
                        bar1.Maximum = max;
                    }
                    else if (bar == 2)
                    {
                        bar2.Maximum = max;
                    }
                }));
            }
            catch { }
        }
    }
}
