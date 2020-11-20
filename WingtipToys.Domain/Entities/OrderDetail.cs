namespace WingtipToys.Domain.Entities
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string Username { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float? UnitPrice { get; set; }
        public Order Order { get; set; }
    }
}
