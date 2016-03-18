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
    public partial class Options : PCSForm
    {
        public static Options instance = new Options();

        public Options()
        {
            InitializeComponent();
        }
    }
}
