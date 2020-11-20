using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WingtipToys.Application.Interfaces;
using WingtipToys.Application.Products.Commands;
using WingtipToys.Domain.Entities;

namespace WingtipToys.Application.Products.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IApplicationDbContext _context;
        public CreateProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
                ProductName = request.ProductName,
                Description = request.Description,
                ImagePath = request.ImagePath,
                UnitPrice = request.UnitPrice,
                CategoryID = request.CategoryID
            };
            _context.Products.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.ProductID;
        }
    }
}
