using pcs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using PearXLib;

namespace pcs
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS"))
            {
                Directory.CreateDirectory(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS");
            }
            this.Text = "PCS " + v.version + " (in-dev)";
            this.Icon = Resources.pcs;
            a.Load("auto.save");
            labelHealth.Text = "Здоровье: " + v.statHealth;
            labelFun.Text = "Настроение: " + v.statFun;
            labelFood.Text = "Еда: " + v.statFood;
            labelSleep.Text = "Сон: " + v.statSleep;
            labelPurity.Text = "Чистота: " + v.statPurity;

        }

        private void autoSave_Tick(object sender, EventArgs e)
        {
            a.autoSave();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Вы действительно хотите выйти", "PCSimulator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                a.autoSave();
            }
            else
            {
                e.Cancel = true;
            }
            
        }
    }
}
