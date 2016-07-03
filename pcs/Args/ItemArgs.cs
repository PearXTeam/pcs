using System.Drawing;

namespace pcs.Args
{
    public class ItemArgs
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public Image Icon { get; set; }
        public string Tooltip { get; set; } = "";
        public long ShopPrice { get; set; } = 100;
        public bool AvailableInShop { get; set; } = true;
    }
}
