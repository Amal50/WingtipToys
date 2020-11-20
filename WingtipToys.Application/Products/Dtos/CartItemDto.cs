using System;

namespace WingtipToys.Application.Products.Dtos
{
    public class CartItemDto
    {
        public string ItemId { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { get; set; }
    }
}
