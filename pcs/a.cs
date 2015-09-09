using System;
using System.IO;
using PearXLib;
using System.Windows.Forms;
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
                v.usePlug = Convert.ToBoolean(str[4]);
                v.useDebug = Convert.ToBoolean(str[5]);
                v.useAutoSave = Convert.ToBoolean(str[6]);
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
                v.usePlug.ToString(),
                v.useDebug.ToString(),
                v.useAutoSave.ToString()
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

        public static void autoSave()
        {
            if (v.useAutoSave)
            {
                a.Save("auto.save");
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

    }
}
