using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    public partial class DebugMenu : Form
    {
        public DebugMenu()
        {
            InitializeComponent();
        }

        private void textBoxCommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch(textBoxCommandLine.Text)
                {
                    case "moreMoney":
                        a.mMoney(1, 100);
                        break;
                    case "noMoreMoney":
                        a.mMoney(-1, 100);
                        break;
                    case "restoreHealth":
                        a.mHealth(1, 100);
                        break;
                    case "restoreFood":
                        a.mFood(1, 100);
                        break;
                    case "restoreFun":
                        a.mFun(1, 100);
                        break;
                    case "restoreSleep":
                        a.mSleep(1, 100);
                        break;
                    case "restoreAllStates":
                        a.mHealth(1, 100);
                        a.mFood(1, 100);
                        a.mFun(1, 100);
                        a.mSleep(1, 100);
                        break;
                    case "moreXP":
                        a.mXP(1, 100);
                        break;
                    case "noMoreXP":
                        a.mXP(-1, 100);
                        break;
                }
            }
        }
    }
}
