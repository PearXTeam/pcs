namespace pcs.Types
{
    public interface SCommand
    {
        string Command();
        void OnPerform(string[] args);
    }
}
