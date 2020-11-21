using AutoMapper;
using MediatR;
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
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Product>(request);
            _context.Products.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.ProductID;
        }
    }
}
