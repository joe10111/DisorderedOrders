using System.Diagnostics.Eventing.Reader;

namespace DisorderedOrdersMVC.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<int> StockQuantityPerItem = new List<int>();

        public List<Product> ItemsInInventory = new List<Product>();

        public bool InStock(int qty, Product item)
        {
            return item.StockQuantity >= qty;
        }

        public void IncreaseStock(int qty, Product item)
        {
            item.StockQuantity += qty;
        }

        public void DecreaseStock(int qty, Product item)
        {
            item.StockQuantity -= qty;
        }
    }
}
