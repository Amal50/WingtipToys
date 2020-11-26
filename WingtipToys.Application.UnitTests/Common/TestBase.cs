using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using WingtipToys.Application.Products.MappingProfiles;
using WingtipToys.Domain.Entities;
using WingtipToys.Presistence;

namespace WingtipToys.Application.UnitTests.Common
{
    public class TestBase : IDisposable
    {
        protected readonly ApplicationDbContext _context;
        public IMapper Mapper { get; private set; }
        public TestBase()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
            _context = new ApplicationDbContext(options);
            _context.Database.EnsureCreated();
            Seed(_context);

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductMappingProfile>();
            });

            Mapper = configurationProvider.CreateMapper();
        }
        private void Seed(ApplicationDbContext context)
        {
            var products = new[]
            {
                new Product {
                    ProductID = 1 ,
                    ProductName="Product Name 1",
                    Description = "Description 1" ,
                    CategoryID = 1,
                    ImagePath="image1.jpg",
                    UnitPrice = 10
                },
                new Product {
                    ProductID = 2 ,
                    ProductName="Product Name 2",
                    Description = "Description 2" ,
                    CategoryID = 2,
                    ImagePath="image2.jpg",
                    UnitPrice = 20
                },
                new Product {
                    ProductID = 3 ,
                    ProductName="Product Name 3",
                    Description = "Description 3" ,
                    CategoryID = 3,
                    ImagePath="image3.jpg",
                    UnitPrice = 30
                },
                new Product {
                    ProductID = 4 ,
                    ProductName="Product Name 4",
                    Description = "Description 4" ,
                    CategoryID = 4,
                    ImagePath="image4.jpg",
                    UnitPrice = 40
                }
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Database.EnsureCreated();
            _context.Dispose();
        }
    }
}
