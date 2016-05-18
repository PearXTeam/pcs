using System.Windows.Forms;

namespace pcs.Components
{
    public class AchievementListElement : PCSInvItem
    {
        public string AssociatedAchievement { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Achievement.GetAchievement(AssociatedAchievement).Unlocked)
            {
                e.Graphics.DrawImage(PCSImages.Check, 0, 0, Size.Width / 3, Size.Height);
            }
        }
    }
}
