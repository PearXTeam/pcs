using pcs.Components;

namespace pcs.Init
{
    public class PCSAchievements
    {
        public static Achievement Lie = new Achievement(PCS.Loc.GetString("title.gameover"), "nulldesc", PCSImages.Settings, 200, "PCS_Lie");
    }
}
