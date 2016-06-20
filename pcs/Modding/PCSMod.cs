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
        /// Mod author (ex. "SuperModCreator").
        /// </summary>
        /// <returns>Mod author</returns>
        string Author();
        /// <summary>
        /// Mod ID. Please use only Latin symbols, numbers and "_" (ex. "simplepcsmod").
        /// </summary>
        /// <returns>Mod ID</returns>
        string ModID();
        /// <summary>
        /// Mod Version (ex. "1.0.1")
        /// </summary>
        /// <returns>Mod version</returns>
        string Version();
        /// <summary>
        /// Mod initialization event.
        /// </summary>
        void Init();
        /// <summary>
        /// Pre-Initialization.
        /// </summary>
        void PreInit();
        /// <summary>
        /// Post-Initialization.
        /// </summary>
        void PostInit();
    }
}
