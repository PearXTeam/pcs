using System;
using System.IO;
using PearXLib;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing;
namespace pcs
{
    class a
    {
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
                v.catchcat_record.ToString()
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
            }
            else if (plus_or_minus == 1)
            {
                v.statFood += value;
                if (v.statFood > 100)
                {
                    v.statFood = 100;
                }
            }
            Program.g.labelFood.Text = "Еда: " + v.statFood;
            Program.g.barFood.Value = v.statFood;
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
            }
            else if (plus_or_minus == 1)
            {
                v.statFun += value;
                if (v.statFun > 100)
                {
                    v.statFun = 100;
                }
            }
            Program.g.labelFun.Text = "Настроение: " + v.statFun;
            Program.g.barFun.Value = v.statFun;

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
            }
            else if (plus_or_minus == 1)
            {
                v.statSleep += value;
                if (v.statSleep > 100)
                {
                    v.statSleep = 100;
                }
            }
            Program.g.labelSleep.Text = "Сон: " + v.statSleep;
            Program.g.barSleep.Value = v.statSleep;

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
            }
            else if (plus_or_minus == 1)
            {
                v.statHealth += value;
                if (v.statHealth > 100)
                {
                    v.statHealth = 100;
                }
            }
            Program.g.labelHealth.Text = "Здоровье: " + v.statHealth;
            Program.g.barHealth.Value = v.statHealth;

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

        public static void mMoney(short plus_or_minus, BigInteger value)
        {
            if (plus_or_minus == -1)
            {
                v.money -= value;
            }
            else if (plus_or_minus == 1)
            {
                v.money += value;
            }
            Program.g.labelMoney.Text = "Деньги: " + v.money + "Р";
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
            Program.g.labelXP.Text = "Опыт: " + v.money + "XP";
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
                v.statHealth = 100;
                v.statFun = 100;
                v.statFood = 100;
                v.statSleep = 100;
                v.money = 500;
                v.xp = 100;
                v.catchcat_record = 0;
                v.forceClose = true;
                File.Create(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS" + PXL.s + "reset");
                Application.Exit();
            }
        }
    }
}
