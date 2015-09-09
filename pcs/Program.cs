using System;
using System.Collections.Generic;
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
            a.Load("auto.save");
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
