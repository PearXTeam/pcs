
using System.Drawing;
using pcs.Player;

namespace pcs.Components
{
    public class Achievement
    {
        private string _Name = "Simple Achievement";
        private string _Desc = "This is a simple achievement!";
        private Image _Icon = PCSImages.TrophyBig;
        private long _GiveXP;
        private string _ID = "PSC_SimpleAchievement";

        public Achievement() { }

        public Achievement(string name, string desc, Image icon, long givexp, string id)
        {
            _Name = name;
            _Desc = desc;
            _Icon = icon;
            _GiveXP = givexp;
            _ID = id;
        }

        public bool Unlocked { get; set; }

        public virtual string Name()
        {
            return _Name;
        }

        public virtual string Desc()
        {
            return _Desc;
        }

        public virtual Image Icon()
        {
            return _Icon;
        }

        public virtual long GiveXP()
        {
            return _GiveXP;
        }

        public virtual string ID()
        {
            return _ID;
        }

        public virtual void OnUnlock()
        {
            PCS.l.Add("Unlocked" + ID() + "achievement!");
        }

        public static void Unlock(string id)
        {
            foreach (Achievement ach in Registry.RegisteredAchievements)
            {
                if (ach.ID() == id)
                {
                    if (!ach.Unlocked)
                    {
                        new PopUp().Display(PCS.Loc.GetString("achievement.unlocked"), ach.Name() + " - " + ach.Desc(), 7000);
                        ach.Unlocked = true;
                        ach.OnUnlock();
                        PlayerVals.XP += ach.GiveXP();
                    }
                    return;
                }
            }
        }

        public static Achievement GetAchievement(string id)
        {
            foreach (Achievement ach in Registry.RegisteredAchievements)
            {
                if (ach.ID() == id)
                {
                    return ach;
                }
            }
            return null;
        }

    }
}
