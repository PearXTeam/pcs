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
using System.Diagnostics;
using System.Net;

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
            Random rand = new Random();
            this.Text = "PCS " + v.version + " (in-dev) with " + words.wrds[rand.Next(0, (int)words.wrds.GetLongLength(0))];
            this.Icon = Resources.pcs;
            if (v.backgroundImage != null && File.Exists(v.backgroundImage))
            {
                this.BackgroundImage = Image.FromFile(v.backgroundImage);
            }
            a.Setup();
        }

        private void autoSave_Tick(object sender, EventArgs e)
        {
            if (v.useAutoSave)
            {
                a.Save("auto.save");
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (v.forceClose == false)
            {
                DialogResult r = MessageBox.Show("Вы действительно хотите выйти", "PCSimulator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    a.Save("auto.save");
                    File.WriteAllText(PXL.documents + PXL.s + "PearX" + PXL.s + "PCS" + PXL.s + "plug.save", v.usePlug.ToString());
                    v.forceClose = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void timerFood_Tick(object sender, EventArgs e)
        {
            a.mFood(-1, 1);
        }

        private void timerSleep_Tick(object sender, EventArgs e)
        {
            a.mSleep(-1, 1);
        }

        private void timerFun_Tick(object sender, EventArgs e)
        {
            a.mFun(-1, 1);
        }

        private void imageSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
        }

        private void imageSaveManager_Click(object sender, EventArgs e)
        {
            SaveManager sm = new SaveManager();
            sm.ShowDialog();
        }

        private void imageInfo_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void imageVK_Click(object sender, EventArgs e)
        {
            Process.Start("http://vk.com/share.php?url=http://pearx.ru/pcs&title=PCSimulator - симулятор жизни." + "&description=У меня в PCSimulator уже " + v.money + " рублей и " + v.xp + " опыта! Сможешь ли ты накопить больше? Присоединяйся!&image=http://files.pearx.ru/images/pcs.png");
        }

        private void imageMiniGames_Click(object sender, EventArgs e)
        {
            MiniGames mg = new MiniGames();
            mg.ShowDialog();
        }

        private void imageInv_Click(object sender, EventArgs e)
        {
            InvGui ig = new InvGui();
            ig.ShowDialog();
        }

        private void imageShop_Click(object sender, EventArgs e)
        {
            Shop s = new Shop();
            s.ShowDialog();
        }

        private void imageSleep_Click(object sender, EventArgs e)
        {
            Sleep s = new Sleep();
            s.ShowDialog();
        }

        private void imageUpdaterGUI_Click(object sender, EventArgs e)
        {
            UpdaterGUI ugui = new UpdaterGUI();
            ugui.ShowDialog();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && v.useDebug)
            {
                DebugMenu dm = new DebugMenu();
                dm.ShowDialog();
            }
        }

        private void imageSkills_Click(object sender, EventArgs e)
        {
            SkillsGUI sgui = new SkillsGUI();
            sgui.ShowDialog();
        }
    }
}