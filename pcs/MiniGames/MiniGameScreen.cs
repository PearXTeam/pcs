using System.Drawing;
using System.Windows.Forms;
using PearXLib.Engine;

namespace pcs.MiniGames
{
    public class MiniGameScreen : XControlBase
    {
        public Image Overlay { get; set; }

        public MiniGameScreen()
        {
            Size = new Size(512, 384);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if(Overlay != null)
                e.Graphics.DrawImage(Overlay, 0, 0, Size.Width, Size.Height);
        }
    }
}
