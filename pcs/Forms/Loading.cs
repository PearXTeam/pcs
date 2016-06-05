using pcs.Modding;
using pcs.Player;
using PearXLib;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using pcs.Components;

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
                SetMax(1, 7);
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
                SetMax(2, 7);

                SetVal(2, 0);
                SetText(2, "Unpacking default langs...");
                File.WriteAllBytes(PCS.PathLangs + "ru_RU.lang", EmbLangs.EmbLangs.ru_RU);
                File.WriteAllBytes(PCS.PathLangs + "ru_RU.langinfo", EmbLangs.EmbLangs.ru_RU_inf);
                File.WriteAllBytes(PCS.PathLangs + "en_US.lang", EmbLangs.EmbLangs.en_US);
                File.WriteAllBytes(PCS.PathLangs + "en_US.langinfo", EmbLangs.EmbLangs.en_US_inf);

                SetVal(2, 1);
                SetText(2, "Selecting lang...");
                Setup.InitLang(this);

                SetVal(2, 2);
                SetText(2, "Initing random stuff...");
                Setup.Init();

                SetVal(2, 3);
                SetText(2, "Setuping titles...");
                Setup.SetupTitles();

                SetVal(2, 4);
                SetText(2, "Registering...");
                Setup.Register();

                SetVal(2, 5);
                SetText(2, "Setting up default values...");
                Setup.SetupDefaults();

                SetVal(2, 6);
                SetText(2, "Unpacking sounds...");
                Setup.UnpackSounds();
                
                SetVal(2, 7);
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
                SetText(1, "PostIniting game...");
                SetMax(2, 4);

                SetVal(2, 0);
                SetText(2, "Initing icons...");
                Setup.InitToolIcons();

                SetVal(2, 1);
                SetText(2, "Initing achievements...");
                Setup.InitAchievements();

                SetVal(2, 2);
                SetText(2, "Initing images...");
                Setup.InitImages();

                SetVal(2, 3);
                SetText(2, "Initing random stuff...");
                Setup.PostInit();

                SetVal(2, 4);
                SetVal(2, 0);
                SetText(2, "");
                //
                //
                //
                //
                SetVal(1, 5);
                SetText(1, "Loading game...");
                SetMax(2, 2);

                SetText(2, "Loading settings...");
                SL.LoadSettings();
                SetVal(2, 1);

                SetText(2, "Loading savefile...");
                SL.Load("autosave");
                SetVal(2, 2);

                SetVal(2, 0);
                SetText(2, "");
                //
                //
                SetVal(1, 6);
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
                SetVal(1, 7);
                SetText(1, "Done");
                //
                //
                Invoke(new MethodInvoker(() =>
                {
                    ShowNew(Game.instance);
                }));
            }).Start();
        }

        public void SetText(byte label, string text)
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

        public void SetVal(byte bar, int val)
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

        public void SetMax(byte bar, int max)
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
