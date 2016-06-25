using System.Collections.Generic;
using System.Windows.Forms;

namespace pcs.IAI
{
    public class InventoryUtils
    {
        public static List<InventoryGUIContainer> GetInventories()
        {
            List<InventoryGUIContainer> l = new List<InventoryGUIContainer>();
            foreach (Form f in Application.OpenForms)
            {
                if (f is IInventory)
                {
                    foreach (Control c in f.Controls)
                    {
                        var igc = c as InventoryGUIContainer;
                        if(igc != null)
                            l.Add(igc);
                    }
                }
            }
            return l;
        }
    }
}
