namespace pcs.Types
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
