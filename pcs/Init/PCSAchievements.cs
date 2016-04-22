using pcs.Components;

namespace pcs.Init
{
    public class PCSAchievements
    {
        public static Achievement Coder = new Achievement(PCS.Loc.GetString("achievement.coder"), PCS.Loc.GetString("achievement.coder.desc"), PCSImages.Code, 1, "PCS_Coder");
    }
}
