using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace pcs
{
    class v
    {
        //Системные значения \/
        public static bool forceClose = false;

        //Загружаемые параметры \/
        public static string version = "1.0.0.0";

        
        public static short statHealth = 100;
        public static short statFun = 100;
        public static short statFood = 100;
        public static short statSleep = 100;

        public static bool usePlug = false;
        public static bool useDebug = true;
        public static bool useAutoSave = true;

        public static BigInteger money = 500;
        public static BigInteger xp = 100;

        public static Color backgroundColor = Color.Black;
        public static string backgroundImage = null;

        public static BigInteger catchcat_record = 0;
        //TODO: Ачивки
    }
}
