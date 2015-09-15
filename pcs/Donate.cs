using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs
{
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void buttonShareFriends_Click(object sender, EventArgs e)
        {
            panelShare.Visible = true;
        }

        private void imageShareGP_Click(object sender, EventArgs e)
        {
            Process.Start("https://plus.google.com/share?url=http://pcs.pearx.ru");
        }

        private void imageShareVK_Click(object sender, EventArgs e)
        {
            Process.Start("http://vk.com/share.php?url=http://pcs.pearx.ru/");
        }

        private void imageShareFB_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/sharer/sharer.php?u=http://pcs.pearx.ru/");
        }

        private void imageShareTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/intent/tweet?url=http://pcs.pearx.ru/");
        }

        private void buttonFinancialHelp_Click(object sender, EventArgs e)
        {
            panelMoney.Visible = true;
        }

        private void buttonHelpDev_Click(object sender, EventArgs e)
        {
            Process.Start("http://github.com/mrAppleXZ/pcs");
        }

        private void buttonBugReport_Click(object sender, EventArgs e)
        {
            Process.Start("http://pcs.pearx.ru/bugreport.html");
        }

        private void buttonWMR_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("R935699805560");
        }

        private void buttonWMZ_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Z202297004406");
        }

        private void buttonYM_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("410012477624296");
        }
    }
}
