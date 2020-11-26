using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WingtipToys.Application.Products.Dtos;
using WingtipToys.Application.Products.Handlers;
using WingtipToys.Application.Products.Queries;
using WingtipToys.Application.UnitTests.Common;

namespace WingtipToys.Application.UnitTests
{
    [TestFixture]
    public class GetProductsQueryHandlerTests : TestBase
    {
        [Test]
        public async Task ShouldReturnAllProducts()
        {
            var query = new GetProductsQueryHandler(_context, Mapper);
            var result = await query.Handle(new GetProductsQuery(), CancellationToken.None);
            Assert.That(result, Is.TypeOf<List<GetProductDto>>());
            Assert.AreEqual(result.Count, 4);
        }
    }
}
