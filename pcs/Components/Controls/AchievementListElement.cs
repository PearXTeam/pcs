using System.Windows.Forms;
using pcs.Init;

namespace pcs.Components.Controls
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
