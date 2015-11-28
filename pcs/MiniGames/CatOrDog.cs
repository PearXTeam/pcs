using PearXLib;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace pcs.MiniGames
{
    public partial class CatOrDog : Form
    {
        private bool isGameStarted = false;
        private int score = 0;
        private CatOrDogType CODT;
        private CatOrDogElement[] CODEs = Registry.RegisteredCatOrDogElements.ToArray();

        public CatOrDog()
        {
            InitializeComponent();
            this.Text = v.l.GetString("title.catOrDog");
        }

        private void CatOrDog_Load(object sender, System.EventArgs e)
        {
            Location = PXL.GetFormStartPosition(v.g, this);
        }

        private void Gen()
        {
            int index = RandomUtils.GenNumber(v.Rand, 0, Registry.RegisteredCatOrDogElements.Count - 1);
            CatOrDogElement CODE = CODEs[index];
            CODT = CODE.Type();
            image.Image = CODE.Image();
            image.Refresh();
        }

        private void CatOrDog_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameStarted)
            {
                if (CODT == CatOrDogType.Cat && e.KeyCode == Keys.Left || CODT == CatOrDogType.Dog && e.KeyCode == Keys.Right)
                {
                    score++;
                    if (v.CatOrDogHighScore < score)
                    {
                        v.CatOrDogHighScore = score;
                    }
                    using (SoundPlayer sp = new SoundPlayer(PearXLib.Properties.Resources.bd))
                    {
                        sp.Play();
                    }
                    Gen();
                }
                else
                {
                    v.Money += score / 5;
                    score = 0;
                    using (SoundPlayer sp = new SoundPlayer(PearXLib.Properties.Resources.Error))
                    {
                        sp.Play();
                    }
                    Gen();
                }
            }
            else
            {
                isGameStarted = true;
                Gen();
            }
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            if (!isGameStarted)
                e.Graphics.DrawString(v.l.GetString("catordog.start"), new Font("Microsoft Sans MS", 18F), Brushes.Black, new PointF(0F, image.Size.Height - 52F));

            e.Graphics.DrawString(v.l.GetString("other.score") + score.ToString(), new Font("Microsoft Sans MS", 16F), Brushes.Black, new PointF(0F, 0F));
            e.Graphics.DrawString(v.l.GetString("other.highscore") + v.CatOrDogHighScore, new Font("Microsoft Sans MS", 16F), Brushes.Black, new PointF(0F, 16F));
        }

        private void CatOrDog_FormClosing(object sender, FormClosingEventArgs e)
        {
            v.Money += score / 5;
        }
    }
}
