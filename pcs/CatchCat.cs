using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    public partial class CatchCat : Form
    {
        BigInteger score;
        public CatchCat()
        {
            InitializeComponent();
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int i = rand.Next(1, 5);
            if (i == 1)
            {
                imageCat.Location = new Point(31, 54);
            }
            else if (i == 2)
            {
                imageCat.Location = new Point(537, 198);
            }
            else if (i == 3)
            {
                imageCat.Location = new Point(110, 339);
            }
            else if (i == 4)
            {
                imageCat.Location = new Point(380, 142);
            }
            else if (i == 5)
            {
                imageCat.Location = new Point(612, 39);
            }
            
        }

        private void imageCat_Click(object sender, EventArgs e)
        {
            score++;
            labelScore.Text = "Очки:" + score;
            if (v.catchcat_record < score)
            {
                v.catchcat_record = score;
                labelRecord.Text = "Рекорд: " + v.catchcat_record.ToString();
            }
        }

        private void CatchCat_FormClosing(object sender, FormClosingEventArgs e)
        {
            BigInteger i = score / 3;
            MessageBox.Show("Вы заработали " + score + " очка(ов).\nЗа это Вы получаете " + i + " монет.");
            a.mMoney(1, i);
        }

        private void CatchCat_Load(object sender, EventArgs e)
        {
            labelRecord.Text = "Рекорд: " + v.catchcat_record.ToString();
        }
    }
}
