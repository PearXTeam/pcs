using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pcs.Components;

namespace pcs.Forms
{
    public partial class AchievementList : PCSForm
    {
        public static AchievementList instance = new AchievementList();

        public AchievementList()
        {
            InitializeComponent();
        }

        private void AchievementList_Shown(object sender, EventArgs e)
        {
            foreach (Control c in panelAchievements.Controls)
            {
                if (c is AchievementListElement)
                {
                    AchievementListElement ale = (AchievementListElement) c;
                    Achievement ach = Achievement.GetAchievement(ale.AssociatedAchievement);
                    if (ach.Unlocked)
                        ((AchievementListElement)c).ColorName = Color.FromArgb(39, 174, 96);
                    else
                        ((AchievementListElement)c).ColorName = Color.FromArgb(192, 57, 43);
                }
            }
        }
    }
}
