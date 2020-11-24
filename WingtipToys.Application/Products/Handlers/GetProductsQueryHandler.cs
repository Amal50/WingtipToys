using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WingtipToys.Application.Interfaces;
using WingtipToys.Application.Products.Dtos;
using WingtipToys.Application.Products.Queries;
using WingtipToys.Domain.Entities;

namespace WingtipToys.Application.Products.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IList<GetProductDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<GetProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var result = new List<GetProductDto>();
            List<Product> products = await _context.Products.ToListAsync();
            if(products != null)
            {
                result = _mapper.Map<List<GetProductDto>>(products);
            }
            return result;
        }
    }
}
