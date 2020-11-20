using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WingtipToys.Application.Products.Dtos;

namespace WingtipToys.Application.Products.Queries
{
    public class GetProductsByCategotyIdQuery : IRequest<IList<GetProductDto>>
    {
        public int CategoryID { get; set; }
    }
}
