using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs.Forms
{
    public partial class AchievementList : PCSForm
    {
        public static AchievementList instance = new AchievementList();

        public AchievementList()
        {
            InitializeComponent();
        }
    }
}
