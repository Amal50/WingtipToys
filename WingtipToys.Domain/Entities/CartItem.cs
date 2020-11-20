using System;

namespace WingtipToys.Domain.Entities
{
    public class CartItem
    {
        public string ItemId { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
