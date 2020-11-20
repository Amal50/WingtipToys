using MediatR;

namespace WingtipToys.Application.Products.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public float? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
    }
}
