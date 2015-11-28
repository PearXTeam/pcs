using pcs.Types;
using PearXLib;
using PearXLib.Engine;
using System.Drawing;
using System.Windows.Forms;

namespace pcs
{
    public partial class MiniGamesGui : Form
    {
        public MiniGamesGui()
        {
            InitializeComponent();
            Text = v.l.GetString("title.miniGames");
            #region Icons init
            int column = 0;
            int row = 0;
            foreach (SIcon i in Registry.RegisteredMiniGameIcons)
            {
                XIcon xi = new XIcon();
                xi.Title = i.Name();
                xi.Icon = i.Icon();
                xi.Font = new Font("Microsoft Sans MS", 13F, FontStyle.Regular);
                xi.Click += i.OnClick;
                xi.Size = new Size(90, 90 + (int)xi.TitleWidthHeight.Height);
                xi.Location = new Point((100 * row) + 10, (136 * column) + 10);
                xi.ForeColor = Color.DarkOrange;
                xi.Cursor = Cursors.Hand;
                row++;
                if (row == 4)
                {
                    column++;
                    row = 0;
                }
                Controls.Add(xi);
            }
            #endregion
        }

        private void MiniGamesGui_Load(object sender, System.EventArgs e)
        {
            Location = PXL.GetFormStartPosition(v.g, this);
        }
    }
}
