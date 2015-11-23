using pcs.Modding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs
{
    public partial class ModList : Form
    {
        public ModList()
        {
            InitializeComponent();
            Text = v.l.GetString("title.modlist");
            listViewMods.Columns.Add(v.l.GetString("modlist.name"), 150);
            listViewMods.Columns.Add(v.l.GetString("modlist.author"), 150);
            listViewMods.Columns.Add(v.l.GetString("modlist.version"), 150);
            foreach(PCSMod pcsm in Getting.GetMods())
            {
                listViewMods.Items.Add(new ListViewItem(new string[]{pcsm.Name(), pcsm.Author(), pcsm.Version()}));
            }
        }
    }
}
