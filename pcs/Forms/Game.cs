namespace pcs.Forms
{
    public partial class Game : PCSForm, IMain
    {
        public static Game instance = new Game();
        public Game()
        {
            InitializeComponent();
        }
    }
}
