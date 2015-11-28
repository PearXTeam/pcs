using System;
using System.Drawing;

namespace pcs.Types
{
    public interface SIcon
    {
        string Name();
        Image Icon();
        void OnClick(object sender, EventArgs e);
    }
}
