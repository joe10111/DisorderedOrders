using System.Diagnostics.Eventing.Reader;

namespace DisorderedOrdersMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public int Price { get; set; }
        
        /*
        public bool InStock(int qty)
        {
            return StockQuantity >= qty;
        }

        public void DecreaseStock(int qty)
        {
            StockQuantity -= qty;
        }
        */
    }
}
