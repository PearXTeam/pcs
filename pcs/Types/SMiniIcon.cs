using System;
using System.Drawing;

namespace pcs.Types
{
    public interface SMiniIcon
    {
        Image Icon();
        void OnClick(object sender, EventArgs e);
    }
}
