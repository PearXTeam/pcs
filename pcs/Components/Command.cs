using System;
using pcs.Core;
using pcs.Forms;
using PearXLib;

namespace pcs.Components
{
    public class Command
    {
        public virtual string Name()
        {
            throw new NotImplementedException();
        }

        public virtual void OnPerform(string[] args, string allArgs)
        {
            throw new NotImplementedException();
        }

        public static void AddToConsole(string msg)
        {
            PCS.l.Add(msg, LogType.Info);
            ConsoleForm.instance.lblText.Text += msg + "\n";
            ConsoleForm.instance.panel.VerticalScroll.Value = ConsoleForm.instance.panel.VerticalScroll.Maximum;
        }

        public static void AddToConsole(string msg, LogType t)
        {
            PCS.l.Add(msg, t);
            string s = "";
            switch (t)
            {
                case LogType.Info:
                    s = "[" + PCS.Loc.GetString("other.info") + "] ";
                    break;
                case LogType.Error:
                    s = "[" + PCS.Loc.GetString("other.error") + "] ";
                    break;
                case LogType.Other:
                    s = "[" + PCS.Loc.GetString("other.other") + "] ";
                    break;
                case LogType.Warning:
                    s = "[" + PCS.Loc.GetString("other.warning") + "] ";
                    break;
            }
            ConsoleForm.instance.lblText.Text += s + msg + "\n";
            ConsoleForm.instance.panel.VerticalScroll.Value = ConsoleForm.instance.panel.VerticalScroll.Maximum;
        }

        public static void ClearConsole()
        {
            PCS.l.Add("Console cleared.");
            ConsoleForm.instance.lblText.Text = "";
            ConsoleForm.instance.panel.VerticalScroll.Value = ConsoleForm.instance.panel.VerticalScroll.Maximum;
        }
    }
}
