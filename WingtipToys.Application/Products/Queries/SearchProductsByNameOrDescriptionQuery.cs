using MediatR;
using System.Collections.Generic;
using WingtipToys.Application.Products.Dtos;

namespace WingtipToys.Application.Products.Queries
{
    public class SearchProductsByNameOrDescriptionQuery : IRequest<IList<GetProductDto>>
    {
        public string SearchText { get; set; }
    }
}
