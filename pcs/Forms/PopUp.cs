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
    public partial class PopUp : PCSForm
    {
        public PopUp()
        {
            InitializeComponent();
        }

        public void Display(string title, string text, int autoClose)
        {
            Text = title;
            lblMsg.Text = text;
            Rim = false;
            TopMost = true;
            PanelBG = BackColor;
            Timer t = new Timer();
            t.Interval = autoClose;
            t.Tick += (sender, args) => { Close(); t.Stop(); };
            t.Start();
            
            Show(Background.instance);
            PCS.PlaySound("PopUp");
            Location = new Point(Background.instance.Width - Width, 0);
        }
    }
}
