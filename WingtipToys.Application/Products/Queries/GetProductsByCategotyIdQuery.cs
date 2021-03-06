﻿using MediatR;
using System.Collections.Generic;
using WingtipToys.Application.Products.Dtos;

namespace WingtipToys.Application.Products.Queries
{
    public class GetProductsByCategotyIdQuery : IRequest<IList<GetProductDto>>
    {
        public int CategoryID { get; set; }
    }
}
