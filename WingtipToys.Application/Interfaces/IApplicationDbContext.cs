using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using WingtipToys.Domain.Entities;

namespace WingtipToys.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<CartItem> CartItems { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
