using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PearXLib;
using PearXLib.Forms;
using pcs.Modding;
using System.Reflection;
using pcs.Types;
using PearXLib.Engine;
using pcs.Properties;

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
            a.AutoLoad();
            a.prepareGame();

            Icon = Resources.pcs;

            #region Icons init
            int column = 0;
            int row = 0;
            foreach(SIcon i in Registry.RegisteredIcons)
            {
                XIcon xi = new XIcon();
                xi.Title = i.Name();
                xi.Icon = i.Icon();
                xi.Click += i.OnClick;
                xi.Size = new Size(90, 103);
                xi.Location = new Point((100 * row) + 10, (113 * column) + 10);
                xi.Font = new Font("Microsoft Sans MS", 13F, FontStyle.Regular);
                xi.ForeColor = Color.DarkOrange;
                row++;
                if (row == 8)
                {
                    column++;
                    row = 0;
                }
                panelIcons.Controls.Add(xi);
            }
            #endregion
            throw new Exception();
        }

        private void panelIcons_MouseEnter(object sender, EventArgs e)
        {
            panelIcons.Focus();
        }

        private void panelIcons_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void timerFood_Tick(object sender, EventArgs e)
        {
            v.Food--;
        }

        private void timerSleep_Tick(object sender, EventArgs e)
        {
            v.Sleep--;
        }

        private void timerMood_Tick(object sender, EventArgs e)
        {
            v.Mood--;
        }

        private void timerPurity_Tick(object sender, EventArgs e)
        {
            v.Purity--;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!v.forceClose)
            {
                DialogResult r = MessageBox.Show(v.l.GetString("other.closeMessage"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    a.AutoSave();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (v.forceCloseUseSave)
                {
                    a.AutoSave();
                }
            }
        }
    }
}
