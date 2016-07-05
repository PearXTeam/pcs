using pcs.Player;
using System.Windows.Forms;
using System;
using pcs.Components;

namespace pcs.Forms
{
    public partial class Game : PCSForm, IMain
    {
        public static Game instance = new Game();

        public Timer timerFood = new Timer();
        public Timer timerSleep = new Timer();
        public Timer timerMood = new Timer();
        public Timer timerAutosave = new Timer();
        public Timer timerTime = new Timer();
        public Timer timerTick = new Timer();

        public byte TickNumber = 0;

        public bool DontSave = false;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timerFood.Start();
            timerSleep.Start();
            timerMood.Start();
            timerAutosave.Start();
            timerTime.Start();
            timerTick.Start();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!DontSave)
            {
                SL.Save("autosave");
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                ConsoleForm.instance.Show(this);
            }
        }
    }
}
