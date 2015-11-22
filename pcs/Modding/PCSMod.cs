using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs.Modding
{
    public interface PCSMod
    {
        string Name();
        string Author();
        string Version();
        void OnGameLoad();
        void OnGamePostLoad();
        void OnGamePreLoad();
    }
}
