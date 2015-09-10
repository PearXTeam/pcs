using PearXLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    static class Program
    {
        public static Game g = new Game();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            if(File.Exists(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS" + PXL.s + "plug.save"))
            {
                v.usePlug = Convert.ToBoolean(File.ReadAllText(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS" + PXL.s + "plug.save"));
            }
            if (File.Exists(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS" + PXL.s + "reset"))
            {
                File.Delete(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS" + PXL.s + "reset");
            }
            else
            {
                a.Load("auto.save");
            }
            
            if (v.usePlug)
            {
                Application.Run(new Plug());
            }
            else
            {
                Application.Run(g);
            }
            
        }
    }
}
