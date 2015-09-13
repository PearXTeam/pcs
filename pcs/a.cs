﻿using System;
using System.IO;
using PearXLib;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing;
namespace pcs
{
    class a
    {
        public enum Message { NoItem }
        /// <summary>
        /// Загружает сохранение.
        /// </summary>
        /// <param name="filename">Имя файла сохранения</param>
        public static void Load(string save)
        {
            try
            {
                string[] str = File.ReadAllLines(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS" + PXL.s + save);
                v.statHealth = Convert.ToInt16(str[0]);
                v.statFun = Convert.ToInt16(str[1]);
                v.statFood = Convert.ToInt16(str[2]);
                v.statSleep = Convert.ToInt16(str[3]);
                v.useDebug = Convert.ToBoolean(str[4]);
                v.useAutoSave = Convert.ToBoolean(str[5]);
                v.money = BigInteger.Parse(str[6]);
                v.xp = BigInteger.Parse(str[7]);
                v.backgroundColor = Color.FromArgb(PXL.cTI(str[8]));
                v.backgroundImage = str[9];
                v.catchcat_record = BigInteger.Parse(str[10]);
                inv.foodBanana = Convert.ToInt64(str[11]);
                inv.foodSoup = Convert.ToInt64(str[12]);
                inv.foodSushi = Convert.ToInt64(str[13]);
                inv.foodCookies = Convert.ToInt64(str[14]);
                inv.foodCupcake = Convert.ToInt64(str[15]);
                inv.foodCherry = Convert.ToInt64(str[16]);
                inv.foodMushroom = Convert.ToInt64(str[17]);
                inv.foodEggPlant = Convert.ToInt64(str[18]);
                inv.foodPepper = Convert.ToInt64(str[19]);
                inv.foodBread = Convert.ToInt64(str[20]);
                inv.foodIceCream = Convert.ToInt64(str[21]);
                inv.foodKiwi = Convert.ToInt64(str[22]);
                inv.foodCheese = Convert.ToInt64(str[23]);
                inv.foodEgg = Convert.ToInt64(str[24]);
                inv.foodTomato = Convert.ToInt64(str[25]);
                inv.foodStrawberry = Convert.ToInt64(str[26]);
                inv.foodHamburger = Convert.ToInt64(str[27]);
                inv.foodCucumber = Convert.ToInt64(str[28]);
                inv.foodCorn = Convert.ToInt64(str[29]);
                inv.foodPie = Convert.ToInt64(str[30]);
                inv.foodCupcake = Convert.ToInt64(str[31]);
                v.catordog_record = BigInteger.Parse(str[32]);
                inv.book1 = Convert.ToInt64(str[33]);
                inv.book2 = Convert.ToInt64(str[34]);
                inv.book3 = Convert.ToInt64(str[35]);
                inv.book4 = Convert.ToInt64(str[36]);
                inv.book5 = Convert.ToInt64(str[37]);
                inv.book6 = Convert.ToInt64(str[38]);
                inv.book7 = Convert.ToInt64(str[39]);
                inv.book8 = Convert.ToInt64(str[40]);
                skills.skillEnglish = Convert.ToBoolean(str[41]);
                skills.skillLiteracy = Convert.ToBoolean(str[42]);
                skills.skillComputer = Convert.ToBoolean(str[43]);
                skills.skillAdvancedMath = Convert.ToBoolean(str[44]);
                skills.skillCpp = Convert.ToBoolean(str[45]);
                
            }
            catch { }
        }

        public static void Save(string save)
        {
            try
            {
                File.WriteAllLines(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS" + PXL.s + save, new string[]{
                v.statHealth.ToString(),
                v.statFun.ToString(),
                v.statFood.ToString(),
                v.statSleep.ToString(),
                v.useDebug.ToString(),
                v.useAutoSave.ToString(),
                v.money.ToString(),
                v.xp.ToString(),
                v.backgroundColor.ToArgb().ToString(),
                v.backgroundImage,
                v.catchcat_record.ToString(),
                inv.foodBanana.ToString(),
                inv.foodSoup.ToString(),
                inv.foodSushi.ToString(),
                inv.foodCookies.ToString(),
                inv.foodCupcake.ToString(),
                inv.foodCherry.ToString(),
                inv.foodMushroom.ToString(),
                inv.foodEggPlant.ToString(),
                inv.foodPepper.ToString(),
                inv.foodBread.ToString(),
                inv.foodIceCream.ToString(),
                inv.foodKiwi.ToString(),
                inv.foodCheese.ToString(),
                inv.foodEgg.ToString(),
                inv.foodTomato.ToString(),
                inv.foodStrawberry.ToString(),
                inv.foodHamburger.ToString(),
                inv.foodCucumber.ToString(),
                inv.foodCorn.ToString(),
                inv.foodPie.ToString(),
                inv.foodCupcake.ToString(),
                v.catordog_record.ToString(),
                inv.book1.ToString(),
                inv.book2.ToString(),
                inv.book3.ToString(),
                inv.book4.ToString(),
                inv.book5.ToString(),
                inv.book6.ToString(),
                inv.book7.ToString(),
                inv.book8.ToString(),
                skills.skillEnglish.ToString(),
                skills.skillLiteracy.ToString(),
                skills.skillComputer.ToString(),
                skills.skillAdvancedMath.ToString(),
                skills.skillCpp.ToString(),
            });
            }
            catch(Exception ex)
            {
                if(v.useDebug)
                {
                    MessageBox.Show(ex.ToString());
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        /// <summary>
        /// Изменяет стат еды.
        /// </summary>
        /// <param name="plus_or_minus">-1 = убавить, 1 = прибавить</param>
        /// <param name="value">значение</param>
        public static void mFood(short plus_or_minus, short value)
        {
            if (plus_or_minus == -1)
            {
                v.statFood -= value;
                if (v.statFood <= 0)
                {
                    a.Kill();
                }
                else
                {
                    Program.g.labelFood.Text = "Еда: " + v.statFood;
                    Program.g.barFood.Value = v.statFood;
                }
            }
            else if (plus_or_minus == 1)
            {
                v.statFood += value;
                if (v.statFood > 100)
                {
                    v.statFood = 100;
                }
                Program.g.labelFood.Text = "Еда: " + v.statFood;
                Program.g.barFood.Value = v.statFood;
            }
        }

        /// <summary>
        /// Изменяет стат настроения.
        /// </summary>
        /// <param name="plus_or_minus">-1 = убавить, 1 = прибавить</param>
        /// <param name="value">значение</param>
        public static void mFun(short plus_or_minus, short value)
        {
            if (plus_or_minus == -1)
            {
                v.statFun -= value;
                if (v.statFun <= 0)
                {
                    a.Kill();
                }
                else
                {
                    Program.g.labelFun.Text = "Настроение: " + v.statFun;
                    Program.g.barFun.Value = v.statFun;
                }
            }
            else if (plus_or_minus == 1)
            {
                v.statFun += value;
                if (v.statFun > 100)
                {
                    v.statFun = 100;
                }
                Program.g.labelFun.Text = "Настроение: " + v.statFun;
                Program.g.barFun.Value = v.statFun;
            }

        }

        /// <summary>
        /// Изменяет стат сна.
        /// </summary>
        /// <param name="plus_or_minus">-1 = убавить, 1 = прибавить</param>
        /// <param name="value">значение</param>
        public static void mSleep(short plus_or_minus, short value)
        {
            if (plus_or_minus == -1)
            {
                v.statSleep -= value;
                if (v.statSleep <= 0)
                {
                    a.Kill();
                }
                else
                {
                    Program.g.labelSleep.Text = "Сон: " + v.statSleep;
                    Program.g.barSleep.Value = v.statSleep;
                }
            }
            else if (plus_or_minus == 1)
            {
                v.statSleep += value;
                if (v.statSleep > 100)
                {
                    v.statSleep = 100;
                }
                Program.g.labelSleep.Text = "Сон: " + v.statSleep;
                Program.g.barSleep.Value = v.statSleep;
            }

        }

        /// <summary>
        /// Изменяет стат здоровья.
        /// </summary>
        /// <param name="plus_or_minus">-1 = убавить, 1 = прибавить</param>
        /// <param name="value">значение</param>
        public static void mHealth(short plus_or_minus, short value)
        {
            if (plus_or_minus == -1)
            {
                v.statHealth -= value;
                if (v.statHealth <= 0)
                {
                    a.Kill();
                }
                else
                {
                    Program.g.labelHealth.Text = "Здоровье: " + v.statHealth;
                    Program.g.barHealth.Value = v.statHealth;
                }
            }
            else if (plus_or_minus == 1)
            {
                v.statHealth += value;
                if (v.statHealth > 100)
                {
                    v.statHealth = 100;
                }
                Program.g.labelHealth.Text = "Здоровье: " + v.statHealth;
                Program.g.barHealth.Value = v.statHealth;
            }

        }

        /// <summary>
        /// Убить игрока.
        /// </summary>
        public static void Kill()
        {
            Program.g.timerFood.Stop();
            Program.g.timerFun.Stop();
            Program.g.timerSleep.Stop();
            Death d = new Death();
            d.ShowDialog();
            v.forceClose = true;
            Application.Exit();
        }

        public static bool mMoney(short plus_or_minus, BigInteger value)
        {
            if (plus_or_minus == -1)
            {
                if (v.money < value)
                {
                    MessageBox.Show("Недостаточно денег!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    v.money -= value;
                    Program.g.labelMoney.Text = "Деньги: " + v.money + "Р";
                    return true;
                }
            }
            else if (plus_or_minus == 1)
            {
                v.money += value;
                Program.g.labelMoney.Text = "Деньги: " + v.money + "Р";
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static void mXP(short plus_or_minus, BigInteger value)
        {
            if (plus_or_minus == -1)
            {
                v.xp -= value;
            }
            else if (plus_or_minus == 1)
            {
                v.xp += value;
            }
            Program.g.labelXP.Text = "Опыт: " + v.xp + "XP";
        }
        public static void Setup()
        {
            Program.g.labelHealth.Text = "Здоровье: " + v.statHealth;
            Program.g.barHealth.Value = v.statHealth;
            Program.g.labelFun.Text = "Настроение: " + v.statFun;
            Program.g.barFun.Value = v.statFun;
            Program.g.labelFood.Text = "Еда: " + v.statFood;
            Program.g.barFood.Value = v.statFood;
            Program.g.labelSleep.Text = "Сон: " + v.statSleep;
            Program.g.barSleep.Value = v.statSleep;
            Program.g.labelMoney.Text = "Деньги: " + v.money + "Р";
            Program.g.labelXP.Text = "Опыт: " + v.xp + "XP";
            Program.g.BackColor = v.backgroundColor;
        }

        public static void Reset()
        {
            DialogResult r = MessageBox.Show("Все Ваши достижения будут удалены!", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                MessageBox.Show("Перезагрузите игру.");
                Program.g.autoSave.Stop();
                v.forceClose = true;
                File.Create(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS" + PXL.s + "reset");
                Application.Exit();
            }
        }

        public static void SM(Message m)
        {
            if (m == Message.NoItem)
            {
                MessageBox.Show("У Вас нет этого предмета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
