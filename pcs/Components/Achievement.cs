
using System.Drawing;

namespace pcs.Components
{
    public class Achievement
    {
        private string _Name = "Simple Achievement";
        private string _Desc = "This is a simple achievement!";
        private Image _Icon = PCSImages.Trophy;
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
    }
}
