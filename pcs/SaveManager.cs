using PearXLib;
using PearXLib.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs
{
    public partial class SaveManager : Form
    {
        public SaveManager()
        {
            InitializeComponent();
            buttonSave.ButtonText = v.l.GetString("savemanager.save");
            Text = v.l.GetString("title.saveManager");
        }

        private void SaveManager_Load(object sender, EventArgs e)
        {
            Location = PXL.GetFormStartPosition(v.g, this);
            Reload();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            textBoxSaveName.Visible = true;
            textBoxSaveName.Focus();
        }

        private void textBoxSaveName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxSaveName.Visible = false;
                if (!String.IsNullOrWhiteSpace(textBoxSaveName.Text) && textBoxSaveName.Text != "auto")
                {
                    a.Save(textBoxSaveName.Text);
                }
                textBoxSaveName.Text = null;
                Reload();
            }
        }

        private void Reload()
        {
            panelSaves.Controls.Clear();
            int column = 0;
            foreach (string s in Directory.GetFiles(v.PathToDir + "saves"))
            {
                if (Path.GetFileName(s) != "auto.save")
                {
                    XButton xb = new XButton();
                    xb.Size = new Size(285, 60);
                    xb.Location = new Point(0, (60 * column) + 10);
                    xb.ButtonText = Path.GetFileNameWithoutExtension(s);
                    xb.Click += (sndr, args) => { a.Load(Path.GetFileNameWithoutExtension(s)); };
                    xb.Font = new Font("Microsoft Sans MS", 16F);
                    panelSaves.Controls.Add(xb);


                    XButton xb2 = new XButton();
                    xb2.Size = new Size(60, 60);
                    xb2.Location = new Point(285, (60 * column) + 10);
                    xb2.GradientColor1 = Color.Red;
                    xb2.GradientColorFocused1 = Color.DarkRed;
                    xb2.ColorPressed = Color.Red;
                    xb2.ButtonText = "X";
                    xb2.Click += (sndr, args) =>
                    {
                        File.Delete(s);
                        Reload();
                    };
                    xb2.Font = new Font("Microsoft Sans MS", 16F);
                    panelSaves.Controls.Add(xb2);
                    column++;
                }
            }
        }
    }
}
