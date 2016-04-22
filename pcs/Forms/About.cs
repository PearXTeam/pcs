using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pcs.Components;

namespace pcs.Forms
{
    public partial class About : PCSForm
    {
        public static About instance = new About();

        public About()
        {
            InitializeComponent();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            Achievement.Unlock("PCS_Coder");
            Process.Start("https://github.com/mrAppleXZ/pcs");
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            Process.Start("http://pcs.pearx.ru/");
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/0l807kFAHrACL4xw");
        }
    }
}
