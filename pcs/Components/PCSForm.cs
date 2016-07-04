using pcs.Properties;
using PearXLib.Engine.Flat;
using System;
using System.Drawing;
using System.Windows.Forms;
using pcs.Core;
using pcs.Forms;
using PearXLib;

namespace pcs.Components
{
    public class PCSForm : FlatForm
    {
        public bool CloseMe; //false

        public PCSForm()
        {
            Icon = Resources.PCSIcon;
            MaximizeBox = false;
            ToTrayBox = false;
            Size = new Size(768, 512);
            StartPosition = FormStartPosition.CenterParent;
            if(!(this is IMain))
            {
                ShowInTaskbar = false;
            }
            KeyPreview = true;
        }

        public override Font Font { get; set; } = new Font("Yanone Kaffeesatz F", 16F);

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (this is IMain)
            {
                PCS.PreviousLocation = Location;
                if (!CloseMe)
                    Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
                Hide();
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            if(!Visible && Owner != null)
                Owner.Focus();
            if (Visible)
            {
                if (this is IMain)
                {
                    Location = PCS.PreviousLocation;
                }
                PCS.l.Add("Opened " + GetType().FullName + " form.", LogType.Info);
                Cursor = Cursors.Default;
            }
        }

        

        protected void ShowNew(Form newForm)
        {
            CloseMe = true;
            newForm.Owner = Background.instance;
            newForm.Show();
            Close();
        }


        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.F12)
            {
                PCS.TakeScreenshot(this, !e.Shift);
            }
        }
    }
}
