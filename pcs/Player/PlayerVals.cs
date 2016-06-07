using System;
using pcs.Forms;
using System.Numerics;

namespace pcs.Player
{
    public class PlayerVals
    {
        private static BigInteger money;
        private static BigInteger xp;
        private static DateTime time;

        public static BigInteger Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
                Game.instance.lblMoney.Text = PCS.Loc.GetString("lbl.money") + value + PCS.Loc.GetString("other.currency");
            }
        }

        public static BigInteger XP
        {
            get
            {
                return xp;
            }
            set
            {
                xp = value;
                Game.instance.lblXP.Text = PCS.Loc.GetString("lbl.xp") + value + PCS.Loc.GetString("other.xp");
            }
        }

        public static DateTime Time
        {
            get { return time; }
            set
            {
                time = value;
                Game.instance.lblTime.Text = value.ToString("dd.MM.yyyy, HH:mm");
            }
        }

    }
}
