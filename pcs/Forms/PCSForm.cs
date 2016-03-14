using pcs.Properties;
using PearXLib.Engine.Flat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcs.Forms
{
    public class PCSForm : FlatForm
    {
        public bool CloseMe = false;

        public PCSForm()
        {
            Icon = Resources.PCSIcon;
            MaximizeBox = false;
            Size = new Size(768, 512);
            StartPosition = FormStartPosition.CenterParent;
            if(!(this is IMain))
            {
                ShowInTaskbar = false;
            }
        }

        private Font f = new Font("Yanone Kaffeesatz", 16F);

        public override Font Font
        {
            get
            {
                return f;
            }

            set
            {
                f = value;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (this is IMain)
            {
                PCS.PreviousLocation = Location;
                if (!CloseMe)
                    Application.Exit();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            if (this is IMain)
            {
                Location = PCS.PreviousLocation;
            }
            base.OnShown(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected void ShowNew(Form newForm)
        {
            CloseMe = true;
            newForm.Owner = Background.instance;
            newForm.Show();
            Close();
        }

    }
}
