using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    public partial class UpdaterGUI : Form
    {
        public UpdaterGUI()
        {
            InitializeComponent();
        }

        private void UpdaterGUI_Load(object sender, EventArgs e)
        {
            WebClient c = new WebClient();
            labelActual.Text = "Актуальная: " + v.actual;
            labelVersion.Text = "Установленная: " + v.version;
        }

        private void runUpd_Click(object sender, EventArgs e)
        {
            a.Save("auto.save");
            v.forceClose = true;
            Process.Start("updater.pcs.exe");
            Application.Exit();
        }
    }
}
