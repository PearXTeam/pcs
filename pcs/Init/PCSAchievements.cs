using pcs.Components;

namespace pcs.Init
{
    public class PCSAchievements
    {
        public static Achievement Coder = new Achievement(PCS.Loc.GetString("achievement.coder"), PCS.Loc.GetString("achievement.coder.desc"), PCSImages.Code, 1, "PCS_Coder");
        public static Achievement ConsoleDetective = new Achievement(PCS.Loc.GetString("achievement.consoleDetective"), PCS.Loc.GetString("achievement.consoleDetective.desc"), PCSImages.ConsoleDetective, 10, "PCS_ConsoleDetective");
    }
}
