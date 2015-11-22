using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs.Types
{
    public interface SCommand
    {
        string Command();
        void OnPerform(string[] args);
    }
}
