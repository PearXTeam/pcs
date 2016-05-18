using System;
using System.Drawing;
using System.IO;
using pcs.Components;
using pcs.Player;
using PearXLib.Engine;
using PearXLib.Engine.Flat;

namespace pcs.Forms
{
    public partial class SaveManager : PCSForm
    {
        public static SaveManager instance = new SaveManager();
        public SaveManager()
        {
            InitializeComponent();
        }

        private void SaveManager_Shown(object sender, EventArgs e)
        {
            GetButtons();
        }

        protected void GetButtons()
        {
            panelSaves.Controls.Clear();
            int i = 0;
            foreach (string s in Directory.GetFiles(PCS.PathSaves))
            {
                string we = Path.GetFileNameWithoutExtension(s);
                PCSButton b = new PCSButton();
                b.Text = we;
                b.Location = new Point(5, 64 * i + 3 * i);
                b.Size = new Size(256, 64);
                b.Click += (o, args) => { SL.Load(we); };
                panelSaves.Controls.Add(b);

                PCSButton bdel = new PCSButton();
                bdel.Text = "X";
                bdel.Color = Color.FromArgb(192, 57, 43);
                bdel.ColorFocused = Color.FromArgb(231, 76, 60);
                bdel.Location = new Point(266, 64 * i + 3 * i);
                bdel.Size = new Size(64, 64);
                bdel.Click += (sender, args) =>
                {
                    File.Delete(s);
                    GetButtons();
                };
                panelSaves.Controls.Add(bdel);
                i++;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PCSInputForm f = new PCSInputForm();
            f.ShowDialog(this);
            SL.Save(f.Inputed);
            GetButtons();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            
                File.Delete(PCS.PathSaves + "autosave.pcs");
                PCS.Restart();
            
        }
    }
}
