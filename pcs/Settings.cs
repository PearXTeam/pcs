using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        bool b = false;
        private void checkDebug_CheckedChanged(object sender, EventArgs e)
        {
            v.useDebug = checkDebug.Checked;
        }

        private void checkPlug_CheckedChanged(object sender, EventArgs e)
        {
            v.usePlug = checkPlug.Checked;
            if (b)
            {
                if (v.usePlug)
                {
                    MessageBox.Show("Заглушка включена! Перезапустите игру!");
                }
                else
                {
                    MessageBox.Show("Заглушка выключена! Перезапустите игру!");
                }
            }
        }
        
        private void Settings_Load(object sender, EventArgs e)
        {
            checkPlug.Checked = v.usePlug;
            checkDebug.Checked = v.useDebug;
            labelColor.ForeColor = v.backgroundColor;
            checkAutosave.Checked = v.useAutoSave;
            b = true;
        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            v.backgroundColor = colorDialog.Color;
            Program.g.BackColor = v.backgroundColor;
            labelColor.ForeColor = v.backgroundColor;
        }

        private void checkAutosave_CheckedChanged(object sender, EventArgs e)
        {
            v.useAutoSave = checkAutosave.Checked;
        }
    }
}
