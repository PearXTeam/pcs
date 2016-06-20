using pcs.Components;
using pcs.Core;
using PearXLib;
using PearXLib.Engine;

namespace pcs.Forms
{
    public partial class SelectLang : PCSForm
    {
        public SelectLang()
        {
            InitializeComponent();
            lbSelectLang.PathToLangs = Dirs.PathLangs;
        }

        private void lbSelectLang_LanguageSelected(object sender, LangEventArgs e)
        {
            PCS.SelectedLang = e.SelectedLang;
            PCS.Loc = new Localization(Dirs.PathLangs, PCS.SelectedLang, "ru_RU");
            Close();
        }
    }
}
