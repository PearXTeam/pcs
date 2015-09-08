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
                v.statPurity = Convert.ToInt16(str[4]);
                v.usePlug = Convert.ToBoolean(str[5]);
                v.useDebug = Convert.ToBoolean(str[6]);
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
                v.statPurity.ToString(),
                v.usePlug.ToString(),
                v.useDebug.ToString()
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

    }
}
