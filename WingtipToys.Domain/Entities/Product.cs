using System.Collections.Generic;

namespace WingtipToys.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<CartItem> CartItems { get; private set; }
    }
}