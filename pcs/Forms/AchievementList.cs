using System;
using System.Drawing;
using pcs.Components;
using pcs.Components.Controls;

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
            foreach (AchievementListElement c in panelAchievements.Controls)
            {
                Achievement ach = Achievement.GetAchievement(c.AssociatedAchievement);
                if (ach.Unlocked)
                {
                    c.ColorName = Color.FromArgb(39, 174, 96);
                }
                else
                    c.ColorName = Color.FromArgb(192, 57, 43);
            }
        }
    }
}
