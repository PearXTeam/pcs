using pcs.Properties;
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
    public partial class AchievementsGUI : Form
    {
        public AchievementsGUI()
        {
            InitializeComponent();
        }

        private void AchievementsGUI_Load(object sender, EventArgs e)
        {
            if (achievements.achLie)
            {
                imageAchLie.Image = Resources.yes;
            }
            else
            {
                imageAchLie.Image = Resources.no;
            }
        }
    }
}
