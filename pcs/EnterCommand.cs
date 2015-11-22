using pcs.Types;
using PearXLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs
{
    public partial class EnterCommand : Form
    {
        public EnterCommand()
        {
            InitializeComponent();
        }

        private void EnterCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (SCommand sc in Registry.RegisteredCommands)
                {
                    if (textBoxCommand.Text.Split(' ')[0] == sc.Command())
                    {
                        string[] str = textBoxCommand.Text.Split(' ');
                        v.Log.Add("Performing command \"" + sc.Command() + "\"...", LogType.Info);
                        sc.OnPerform(str);
                    }
                }
            }
        }
    }
}
