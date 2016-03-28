using PearXLib;

namespace pcs.Forms
{
    public enum DeadBy
    {
        Hunger,
        Bore,
        LackOfSleep,
        Illness
    }


    public partial class GameOver : PCSForm
    {
        public static GameOver instance = new GameOver();

        public GameOver()
        {
            InitializeComponent();
        }

        public void Kill(DeadBy db)
        {
            Game.instance.timerAutosave.Stop();
            Game.instance.timerFood.Stop();
            Game.instance.timerMood.Stop();
            Game.instance.timerSleep.Stop();
            switch(db)
            {
                case DeadBy.Hunger:
                    lblKilledby.Text = PCS.Loc.GetString("gameover.deadby.hunger");
                    break;
                case DeadBy.Bore:
                    lblKilledby.Text = PCS.Loc.GetString("gameover.deadby.bore");
                    break;
                case DeadBy.LackOfSleep:
                    lblKilledby.Text = PCS.Loc.GetString("gameover.deadby.lackofsleep");
                    break;
                case  DeadBy.Illness:
                    lblKilledby.Text = PCS.Loc.GetString("gameover.deadby.illness");
                    break;
            }
            lblKilledby.Location = PXL.GetControlCenterPoint(this, lblKilledby);
            lblGameover.Location = PXL.GetControlCenterPoint(this, lblGameover);
            ShowDialog();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            PCS.Restart();
        }
    }
}
