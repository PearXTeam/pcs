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
                PCS.l.Add("Loading mods...", LogType.Info);
                SetText(1, "Loading mods...");
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



                SetText(1, "Initing mods...");
                SetVal(1, 1);
                PCS.l.Add("Performing OnLoad from mods...", LogType.Info);
                SetMax(2, ModRegistry.Mods.Count);
                foreach (PCSMod m in ModRegistry.Mods)
                {
                    SetVal(2, bar2.Value + 1);
                    SetText(2, "Initing " + m.Name());
                    m.OnStart();
                }
                SetText(2, "");
                SetVal(2, 0);


                SetText(1, "Done");
                SetVal(1, 2);
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
