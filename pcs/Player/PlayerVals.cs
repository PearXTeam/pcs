using pcs.Forms;
using System.Numerics;

namespace pcs.Player
{
    public class PlayerVals
    {
        private static BigInteger money = new BigInteger();
        private static BigInteger xp = new BigInteger();

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

    }
}
