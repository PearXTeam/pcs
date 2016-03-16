using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcs.Modding
{
    /// <summary>
    /// A PCSMod interface. Use this for mods.
    /// </summary>
    public interface PCSMod
    {
        /// <summary>
        /// Mod name (ex. "A Simple PCS Mod").
        /// </summary>
        /// <returns>Mod name</returns>
        string Name();
        /// <summary>
        /// Mod ID. Use only English language symbols, numbers and _ (ex. "simplepcsmod").
        /// </summary>
        /// <returns>Mod ID</returns>
        string ModID();
        /// <summary>
        /// Mod Version (ex. "1.0.1")
        /// </summary>
        /// <returns>Mod version</returns>
        string Version();
        /// <summary>
        /// Mod init event.
        /// </summary>
        void Init();
        /// <summary>
        /// Pre init :b.
        /// </summary>
        void PreInit();
        /// <summary>
        /// Post init :b.
        /// </summary>
        void PostInit();
    }
}
