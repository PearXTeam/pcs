namespace pcs.Components
{
    public class SaveElement
    {
        public string Value;
        public string Name { get; set; }
        public OnLoadedHandler OnLoaded { get; set; }
        public OnSaveHandler OnSave { get; set; }
        public delegate void OnLoadedHandler(string name, string value);
        public delegate void OnSaveHandler(string name, out string value);

        public SaveElement(string namee, OnLoadedHandler onloaded, OnSaveHandler onsave)
        {
            Name = namee;
            OnLoaded = onloaded;
            OnSave = onsave;
        }

        public SaveElement() { }
    }
}
