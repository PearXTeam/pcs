using System.Drawing;
using System.Windows.Forms;
using pcs.Core;
using pcs.Init;
using PearXLib;

namespace pcs.Components
{
    public partial class PopUp : PCSForm
    {
        public PopUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays a new PopUp window.
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="text">Text</param>
        /// <param name="autoClose">Auto close delay in ms</param>
        /// <param name="img">Message icon</param>
        /// <param name="backColor">Background color</param>
        public void Display(string title, string text, Image img = null, int autoClose = 5000, Color? backColor = null)
        {
            if (backColor == null)
                backColor = FlatColors.NotQuiteBlack;
            if (img != null)
                Image.Image = img;
            Text = title;
            lblMsg.Text = text;
            Rim = false;
            TopMost = true;
            BackColor = backColor.Value;
            PanelColor = BackColor;
            Timer t = new Timer();
            t.Interval = autoClose;
            t.Tick += (sender, args) => { Close(); t.Stop(); };
            t.Start();
            
            Show(Background.instance);
            SoundUtils.PlaySound(PCSSounds.PopUp);
            Location = new Point(Background.instance.Width - Width, 0);
        }
    }
}
