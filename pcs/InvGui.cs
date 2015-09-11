﻿using pcs.Properties;
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
    public partial class InvGui : Form
    {
        public InvGui()
        {
            InitializeComponent();
        }
        public void upd()
        {
            labelFoodBananaCount.Text = inv.foodBanana.ToString();
            labelFoodSoupCount.Text = inv.foodSoup.ToString();
            labelFoodSushiCount.Text = inv.foodSushi.ToString();
            labelFoodCookiesCount.Text = inv.foodCookies.ToString();
            labelFoodCupcakeCount.Text = inv.foodCupcake.ToString();
            labelFoodCherryCount.Text = inv.foodCherry.ToString();
            labelFoodMushroomCount.Text = inv.foodMushroom.ToString();
            labelFoodBreadCount.Text = inv.foodBread.ToString();
            labelFoodPepperCount.Text = inv.foodPepper.ToString();
            labelFoodEggPlantCount.Text = inv.foodEggPlant.ToString();
            labelFoodIceCreamCount.Text = inv.foodIceCream.ToString();
            labelFoodKiwiCount.Text = inv.foodKiwi.ToString();
            labelFoodEggCount.Text = inv.foodEgg.ToString();
            labelFoodCheeseCount.Text = inv.foodCheese.ToString();
            labelFoodStrawberryCount.Text = inv.foodStrawberry.ToString();
            labelFoodTomatoCount.Text = inv.foodTomato.ToString();
            labelFoodHamburgerCount.Text = inv.foodHamburger.ToString();
            labelFoodMeatCount.Text = inv.foodMeat.ToString();
            labelFoodCucumberCount.Text = inv.foodCucumber.ToString();
            labelFoodCornCount.Text = inv.foodCorn.ToString();
            labelFoodCakeCount.Text = inv.foodPie.ToString();
            labelFoodCockteilCount.Text = inv.foodCockteil.ToString();
        }
        private void imageFoodBanana_Click(object sender, EventArgs e)
        {
            if (inv.foodBanana > 0)
            {
                a.mFood(1, 3);
                a.mFun(1, 1);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodBanana--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodSoup_Click(object sender, EventArgs e)
        {
            if (inv.foodSoup > 0)
            {
                a.mFood(1, 20);
                a.mHealth(1, 1);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodSoup--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodSushi_Click(object sender, EventArgs e)
        {
            if (inv.foodSushi > 0)
            {
                a.mFood(1, 6);
                Random rand = new Random();
                int i = rand.Next(1, 100);
                if (i >= 50)
                {
                    a.mHealth(-1, 2);
                }
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodSushi--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodCookies_Click(object sender, EventArgs e)
        {
            if (inv.foodCookies > 0)
            {
                a.mFood(1, 1);
                a.mFun(1, 3);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodCookies--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodCupcake_Click(object sender, EventArgs e)
        {
            if (inv.foodCupcake > 0)
            {
                a.mFood(1, 1);
                a.mFun(1, 3);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodCupcake--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodCherry_Click(object sender, EventArgs e)
        {
            if (inv.foodCherry > 0)
            {
                a.mFood(1, 1);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodCherry--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodMushroom_Click(object sender, EventArgs e)
        {
            if (inv.foodMushroom > 0)
            {
                a.mFood(1, 2);
                Random rand = new Random();
                int i = rand.Next(1, 100);
                if (i >= 30)
                {
                    a.mHealth(-1, 2);
                }
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodMushroom--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodEggPlant_Click(object sender, EventArgs e)
        {
            if (inv.foodEggPlant > 0)
            {
                a.mFood(1, 5);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodEggPlant--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodPepper_Click(object sender, EventArgs e)
        {
            if (inv.foodPepper > 0)
            {
                a.mFood(1, 1);
                a.mFun(1, 1);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodPepper--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodBread_Click(object sender, EventArgs e)
        {
            if (inv.foodBread > 0)
            {
                a.mFood(1, 2);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodBread--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodIceCream_Click(object sender, EventArgs e)
        {
            if (inv.foodIceCream > 0)
            {
                a.mFood(1, 3);
                a.mFun(1, 2);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodIceCream--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodCheese_Click(object sender, EventArgs e)
        {
            if (inv.foodCheese > 0)
            {
                a.mFood(1, 4);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodCheese--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void InvGui_Load(object sender, EventArgs e)
        {
            upd();
        }

        private void imageFoodKiwi_Click(object sender, EventArgs e)
        {
            if (inv.foodKiwi > 0)
            {
                a.mFood(1, 3);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodKiwi--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodEgg_Click(object sender, EventArgs e)
        {
            if (inv.foodEgg > 0)
            {
                a.mFood(1, 4);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodEgg--;
                upd();
                Random rand = new Random();
                int i = rand.Next(1, 100);
                if (i >= 20)
                {
                    a.mHealth(-1, 1);
                }
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodTomato_Click(object sender, EventArgs e)
        {
            if (inv.foodTomato > 0)
            {
                a.mFood(1, 5);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodTomato--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodStrawberry_Click(object sender, EventArgs e)
        {
            if (inv.foodStrawberry > 0)
            {
                a.mFood(1, 1);
                a.mFun(1, 3);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodStrawberry--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodHamburger_Click(object sender, EventArgs e)
        {
            if (inv.foodHamburger > 0)
            {
                a.mFood(1, 16);
                a.mFun(1, 1);
                a.mHealth(-1, 1);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodHamburger--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodMeat_Click(object sender, EventArgs e)
        {
            if (inv.foodMeat > 0)
            {
                a.mFood(1, 20);
                a.mFun(1, 1);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodMeat--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodCucumber_Click(object sender, EventArgs e)
        {
            if (inv.foodCucumber > 0)
            {
                a.mFood(1, 4);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodCucumber--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodCorn_Click(object sender, EventArgs e)
        {
            if (inv.foodCorn > 0)
            {
                a.mFood(1, 6);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodCorn--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodPie_Click(object sender, EventArgs e)
        {
            if (inv.foodPie > 0)
            {
                a.mFood(1, 10);
                a.mFun(1, 3);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodPie--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }

        private void imageFoodCockteil_Click(object sender, EventArgs e)
        {
            if (inv.foodCockteil > 0)
            {
                a.mFood(1, 2);
                a.mFun(1, 2);
                SoundPlayer sp = new SoundPlayer(Resources.OmNomNom);
                sp.Play();
                inv.foodCockteil--;
                upd();
            }
            else
            {
                a.SM(a.Message.NoItem);
            }
        }
    }
}
