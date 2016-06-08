using pcs.Forms;
using PearXLib;

namespace pcs.Components
{
    public class Command
    {
        public virtual string Name()
        {
            return "testingcommand";
        }

        public virtual void OnPerform(string[] args, string allArgs)
        {
            PCS.l.Add("I'm a testing command =P.");
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
            ConsoleForm.instance.Refresh();
        }
    }
}
