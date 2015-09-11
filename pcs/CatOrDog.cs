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
    public partial class CatOrDog : Form
    {
        public CatOrDog()
        {
            InitializeComponent();
        }
        BigInteger score;
        int i;
        void gen()
        {
            Random rand = new Random();
            i = rand.Next(1, 23);
            if (i == 1)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat1;

            }
            else if (i == 2)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat2;

            }
            else if (i == 3)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat3;

            }
            else if (i == 4)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat4;

            }
            else if (i == 5)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat5;

            }
            else if (i == 6)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat6;

            }
            else if (i == 7)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat7;

            }
            else if (i == 8)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat8;

            }
            else if (i == 9)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat9;

            }
            else if (i == 10)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat10;

            }
            else if (i == 11)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_cat11;

            }
            else if (i == 12)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog1;

            }
            else if (i == 13)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog2;

            }
            else if (i == 14)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog3;

            }
            else if (i == 15)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog4;

            }
            else if (i == 16)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog5;

            }
            else if (i == 17)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog6;

            }
            else if (i == 18)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog7;

            }
            else if (i == 19)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog8;

            }
            else if (i == 20)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog9;

            }
            else if (i == 21)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog10;

            }
            else if (i == 22)
            {
                imageCatOrDog.Image = pcs.Properties.Resources.cod_dog11;

            }
        }

        private void CatOrDog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (i >= 1 && i<= 11)
                {
                    score++;
                    if (v.catordog_record < score)
                    {
                        v.catordog_record = score;
                        labelRecord.Text = "Рекорд: " + v.catordog_record.ToString();
                    }
                }
                else
                {
                    BigInteger i2 = score / 2;
                    MessageBox.Show("Вы заработали " + score + " очка(ов).\nЗа это Вы получаете " + i2 + " монет.");
                    a.mMoney(1, i2);
                    score = 0;
                }
                labelScore.Text = "Очки: " + score;
                gen();
            }
            if (e.KeyCode == Keys.Right)
            {
                if (i >= 12 && i <= 22)
                {
                    score++;
                    if (v.catordog_record < score)
                    {
                        v.catordog_record = score;
                        labelRecord.Text = "Рекорд: " + v.catordog_record.ToString();
                    }
                }
                else
                {
                    BigInteger i2 = score / 2;
                    MessageBox.Show("Вы заработали " + score + " очка(ов).\nЗа это Вы получаете " + i2 + " монет.");
                    a.mMoney(1, i2);
                    score = 0;
                    
                }
                labelScore.Text = "Очки: " + score;
                gen();
            }
            
        }

        private void CatOrDog_Load(object sender, EventArgs e)
        {
            gen();
            labelRecord.Text = "Рекорд: " + v.catordog_record;
        }

        private void CatOrDog_FormClosing(object sender, FormClosingEventArgs e)
        {
            BigInteger i2 = score / 2;
            MessageBox.Show("Вы заработали " + score + " очка(ов).\nЗа это Вы получаете " + i2 + " монет.");
            a.mMoney(1, i2);
        }
    }
}
