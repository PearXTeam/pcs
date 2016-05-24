using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using pcs.Components;
using pcs.Init;
using PearXLib;

namespace pcs.Forms
{
    public partial class ConsoleForm : PCSForm
    {
        public static ConsoleForm instance = new ConsoleForm();

        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void ConsoleForm_Shown(object sender, EventArgs e)
        {
            Size s = Background.instance.Size;
            Location = new Point(s.Width - Width, s.Height - Height);
            Achievement.Unlock(PCSAchievements.ConsoleDetective.ID());
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true;
            Hide();
        }

        private void boxCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(boxCommand.Text))
                {
                    string s = boxCommand.Text.Remove(0, 1);
                    boxCommand.Text = "";

                    PCS.l.Add("Sended \"" + s + "\" command.", LogType.Info);
                    foreach (Command c in Registry.RegisteredCommands)
                    {
                        if (c.Name() == s.Split(' ')[0])
                        {
                            c.OnPerform(s.Split(' '));
                            return;
                        }
                    }
                    Command.AddToConsole(PCS.Loc.GetString("command.notfound"), LogType.Warning);
                }
            }
        }
    }
}
