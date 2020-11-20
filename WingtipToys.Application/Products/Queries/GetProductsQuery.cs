using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WingtipToys.Application.Products.Dtos;

namespace WingtipToys.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IList<GetProductDto>>
    {

    }
}
