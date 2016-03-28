using pcs.Player;

namespace pcs.Forms
{
    public partial class Options : PCSForm
    {
        public static Options instance = new Options();

        public Options()
        {
            InitializeComponent();
        }



        private void checkAutosave_CheckedChanged(object sender, bool isChecked)
        {
            SettingVals.AutoSave = isChecked;
        }

        private void Options_Load(object sender, System.EventArgs e)
        {
            checkAutosave.Checked = SettingVals.AutoSave;
        }
    }
}
