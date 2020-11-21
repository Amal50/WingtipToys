using System.Collections.Generic;
using WingtipToys.Application.Products.Dtos;

namespace WingtipToys.Web.Mvc.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            ProductsList = new List<GetProductDto>();
        }
        public IList<GetProductDto> ProductsList { get; set; }
        public string SearchText { get; set; }
    }
}
