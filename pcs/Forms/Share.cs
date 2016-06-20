using System;
using pcs.Components;
using pcs.Core;
using PearXLib;

namespace pcs.Forms
{
    public partial class Share : PCSForm
    {
        public static Share instance = new Share();

        public Share()
        {
            InitializeComponent();
        }

        private void btnShareVK_Click(object sender, EventArgs e)
        {
            SocialUtils.ShareVK("http://pcs.pearx.ru/", PCS.Loc.GetString("share.vk.text"));
        }

        private void btnShareTwitter_Click(object sender, EventArgs e)
        {
            SocialUtils.ShareTwitter(PCS.Loc.GetString("share.twitter.text"));
        }
    }
}
