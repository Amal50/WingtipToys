using MediatR;
using System.Collections.Generic;
using WingtipToys.Application.Products.Dtos;

namespace WingtipToys.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IList<GetProductDto>>
    {

    }
}
