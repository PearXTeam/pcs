using pcs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }
        void playSound()
        {
            SoundPlayer sp = new SoundPlayer(Resources.Money);
            sp.Play();
        }
        private void imageFoodMushroom_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 6))
            {
                inv.foodMushroom++;
                playSound();
            }
        }

        private void imageFoodBanana_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 22))
            {
                inv.foodBanana++;
                playSound();

            }
        }

        private void imageFoodSoup_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 115))
            {
                inv.foodSoup++;
                playSound();

            }
        }

        private void imageFoodSushi_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 23))
            {
                inv.foodSushi++;
                playSound();
            }
        }

        private void imageFoodCookies_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 26))
            {
                inv.foodCookies++;
                playSound();
            }
        }

        private void imageFoodCupcake_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 26))
            {
                inv.foodCupcake++;
                playSound();
            }
        }

        private void imageFoodCherry_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 5))
            {
                inv.foodCherry++;
                playSound();
            }
        }

        private void imageFoodEggPlant_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 25))
            {
                inv.foodEggPlant++;
                playSound();
            }
        }

        private void imageFoodPepper_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 14))
            {
                inv.foodPepper++;
                playSound();
            }
        }

        private void imageFoodBread_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 10))
            {
                inv.foodBread++;
                playSound();
            }
        }

        private void imageFoodIceCream_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 29))
            {
                inv.foodIceCream++;
                playSound();
            }
        }

        private void imageFoodKiwi_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 15))
            {
                inv.foodKiwi++;
                playSound();
            }
        }

        private void imageFoodCheese_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 20))
            {
                inv.foodCheese++;
                playSound();
            }
        }

        private void imageFoodEgg_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 28))
            {
                inv.foodEgg++;
                playSound();
            }
        }

        private void imageFoodTomato_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 25))
            {
                inv.foodTomato++;
                playSound();
            }
        }

        private void imageFoodStrawberry_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 26))
            {
                inv.foodStrawberry++;
                playSound();
            }
        }

        private void imageFoodHamburger_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 72))
            {
                inv.foodHamburger++;
                playSound();
            }
        }

        private void imageFoodMeat_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 107))
            {
                inv.foodMeat++;
                playSound();
            }
        }

        private void imageFoodCucumber_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 20))
            {
                inv.foodCucumber++;
                playSound();
            }
        }

        private void imageFoodCorn_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 30))
            {
                inv.foodCorn++;
                playSound();
            }
        }

        private void imageFoodPie_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 71))
            {
                inv.foodPie++;
                playSound();
            }
        }

        private void imageFoodCockteil_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 24))
            {
                inv.foodCockteil++;
                playSound();
            }
        }

        private void imageBook1_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 200))
            {
                inv.book1++;
                playSound();
            }
        }

        private void imageBook2_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 220))
            {
                inv.book2++;
                playSound();
            }
        }

        private void imageBook3_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 300))
            {
                inv.book3++;
                playSound();
            }
        }

        private void imageBook4_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 450))
            {
                inv.book4++;
                playSound();
            }
        }

        private void imageBook5_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 250))
            {
                inv.book5++;
                playSound();
            }
        }

        private void imageBook6_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 50))
            {
                inv.book6++;
                playSound();
            }
        }

        private void imageBook7_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 350))
            {
                inv.book7++;
                playSound();
            }
        }

        private void imageBook8_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 400))
            {
                inv.book8++;
                playSound();
            }
        }

        private void imageMedicineChestSmall_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 150))
            {
                inv.medicineChestSmall++;
                playSound();
            }
        }

        private void imageMedicineChestBig_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 450))
            {
                inv.medicineChestBig++;
                playSound();
            }
        }

        private void imagePill_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 15))
            {
                inv.pill++;
                playSound();
            }
        }
    }
}
