using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WingtipToys.Application.Interfaces;
using WingtipToys.Application.Products.Dtos;
using WingtipToys.Application.Products.Queries;
using WingtipToys.Domain.Entities;

namespace WingtipToys.Application.Products.Handlers
{
    public class GetProductsByCategotyIdHandler : IRequestHandler<GetProductsByCategotyIdQuery, IList<GetProductDto>>
    {
        private readonly IApplicationDbContext _context;
        public GetProductsByCategotyIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IList<GetProductDto>> Handle(GetProductsByCategotyIdQuery request, CancellationToken cancellationToken)
        {
            var result = new List<GetProductDto>();
            List<Product> products = await _context.Products.Include(c => c.CartItems)
                                .Where(c => c.CategoryID == request.CategoryID).ToListAsync();
            if(products != null)
            {
                result = products.Select(c => new GetProductDto
                {
                    CategoryID = c.CategoryID,
                    Description = c.Description,
                    ImagePath = c.ImagePath,
                    ProductID = c.ProductID,
                    ProductName = c.ProductName,
                    UnitPrice = c.UnitPrice
                }).ToList();
            }
            return result;
        }
    }
}
