using pcs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    public partial class Sleep : Form
    {
        public Sleep()
        {
            InitializeComponent();
        }

        private void imageSleep2h_Click(object sender, EventArgs e)
        {
            a.mFood(-1, 2);
            a.mSleep(1, 2);
            SoundPlayer sp = new SoundPlayer(Resources.Sleeping);
            sp.Play();
        }

        private void imageSleep6h_Click(object sender, EventArgs e)
        {
            a.mFood(-1, 6);
            a.mSleep(1, 6);
            SoundPlayer sp = new SoundPlayer(Resources.Sleeping);
            sp.Play();
        }

        private void imageSleep4h_Click(object sender, EventArgs e)
        {
            a.mFood(-1, 4);
            a.mSleep(1, 4);
            SoundPlayer sp = new SoundPlayer(Resources.Sleeping);
            sp.Play();
        }
    }
}
