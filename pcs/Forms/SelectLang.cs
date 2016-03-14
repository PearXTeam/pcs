using PearXLib;
using PearXLib.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs.Forms
{
    public partial class SelectLang : PCSForm
    {
        public SelectLang()
        {
            InitializeComponent();
            lbSelectLang.PathToLangs = PCS.PathLangs;
        }

        private void lbSelectLang_LanguageSelected(object sender, LangEventArgs e)
        {
            PCS.SelectedLang = e.SelectedLang;
            PCS.Loc = new Localization(PCS.PathLangs, PCS.SelectedLang);
            Close();
        }
    }
}
