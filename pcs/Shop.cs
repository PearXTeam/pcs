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

        private void imageFoodMushroom_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 6))
            {
                inv.foodMushroom++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodBanana_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 22))
            {
                inv.foodBanana++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodSoup_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 115))
            {
                inv.foodSoup++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodSushi_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 23))
            {
                inv.foodSushi++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodCookies_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 26))
            {
                inv.foodCookies++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodCupcake_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 26))
            {
                inv.foodCupcake++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodCherry_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 5))
            {
                inv.foodCherry++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodEggPlant_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 25))
            {
                inv.foodEggPlant++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodPepper_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 14))
            {
                inv.foodPepper++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodBread_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 10))
            {
                inv.foodBread++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodIceCream_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 29))
            {
                inv.foodIceCream++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodKiwi_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 15))
            {
                inv.foodKiwi++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodCheese_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 20))
            {
                inv.foodCheese++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodEgg_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 28))
            {
                inv.foodEgg++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodTomato_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 25))
            {
                inv.foodTomato++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodStrawberry_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 26))
            {
                inv.foodStrawberry++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodHamburger_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 72))
            {
                inv.foodHamburger++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodMeat_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 107))
            {
                inv.foodMeat++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodCucumber_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 20))
            {
                inv.foodCucumber++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodCorn_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 30))
            {
                inv.foodCorn++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodPie_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 71))
            {
                inv.foodPie++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageFoodCockteil_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 24))
            {
                inv.foodCockteil++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageBook1_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 200))
            {
                inv.book1++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageBook2_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 220))
            {
                inv.book2++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageBook3_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 300))
            {
                inv.book3++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageBook4_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 450))
            {
                inv.book4++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageBook5_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 250))
            {
                inv.book5++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageBook6_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 50))
            {
                inv.book6++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageBook7_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 350))
            {
                inv.book7++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }

        private void imageBook8_Click(object sender, EventArgs e)
        {
            if (a.mMoney(-1, 400))
            {
                inv.book8++;
                SoundPlayer sp = new SoundPlayer(Resources.Money);
                sp.Play();
            }
        }
    }
}
