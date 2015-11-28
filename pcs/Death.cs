using pcs.Properties;
using System;
using System.Windows.Forms;

namespace pcs
{
    public enum KilledBy
    {
        Hunger,
        Bore,
        LackOfSleep,
        Mud,
        Disease
    }
    public partial class Death : Form
    {
        private KilledBy kb;
        public Death(KilledBy killedBy)
        {
            InitializeComponent();
            kb = killedBy;
        }

        private void Death_Load(object sender, EventArgs e)
        {
            this.Text = v.l.GetString("title.death");
            switch(kb)
            {
                case KilledBy.Hunger:
                    imageKilledBy.Image = Resources.Bones;
                    break;
                case KilledBy.Mud:
                    imageKilledBy.Image = Resources.Trash;
                    break;
                case KilledBy.LackOfSleep:
                    imageKilledBy.Image = Resources.RedEyes;
                    break;
                case KilledBy.Disease:
                    imageKilledBy.Image = Resources.Pills;
                    break;
            }
            buttonClose.ButtonText = v.l.GetString("button.closeDeath");
        }

        private void Death_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            v.forceClose = true;
            Application.Exit();
        }
    }
}
