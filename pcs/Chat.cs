using pcs.Types;
using PearXLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pcs
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        public void Upd()
        {
            panelChat.VerticalScroll.Value = panelChat.VerticalScroll.Maximum;
        }

        private void EnterCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(textBoxChat.Text))
                {
                    if (textBoxChat.Text.Substring(0, 1) == "/")
                    {
                        if (textBoxChat.Text.Length > 1)
                        {
                            bool err = false;
                            int count = 0;
                            int i = textBoxChat.Text.Length;
                            foreach (SCommand sc in Registry.RegisteredCommands)
                            {
                                count++;
                                if (textBoxChat.Text.Substring(1, i - 1).Split(' ')[0] == sc.Command())
                                {
                                    string[] str = textBoxChat.Text.Split(' ');
                                    sc.OnPerform(str);
                                    break;
                                }
                                else
                                {
                                    if (count == Registry.RegisteredCommands.Count)
                                    {
                                        err = true;
                                    }
                                }
                            }
                            if (err)
                            {
                                v.Log.Add(v.l.GetString("other.chat.commandNotFound1") + textBoxChat.Text.Substring(1, i - 1).Split(' ')[0] + v.l.GetString("other.chat.commandNotFound2"), LogType.Info);
                            }
                        }
                    }
                    else
                    {
                        v.Log.Add(textBoxChat.Text, "Chat");
                    }
                }
                textBoxChat.Text = String.Empty;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            Location = new Point((v.g.Location.X + v.g.Size.Width) - Size.Width, (v.g.Location.Y + v.g.Size.Height) - Size.Height);
            labelChat.Text = v.Log.Log;
            Upd();
        }
    }
}
