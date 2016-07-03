using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs.Args
{
    public class FoodItemArgs : ItemArgs
    {
        public int RestoreFood { get; set; } = 0;
        public int RestoreMood { get; set; } = 0;
        public int RestoreSleep { get; set; } = 0;
        public int RestoreHealth { get; set; } = 0;
    }
}
