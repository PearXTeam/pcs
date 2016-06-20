using System.IO;
using pcs.Components;
using pcs.Core;
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

        private void btnChangeLanguage_Click(object sender, System.EventArgs e)
        {
            //TODO: Show dialog
            File.Delete(Dirs.Path + "lang.pcs");
            PCS.Restart(true);
        }
    }
}
