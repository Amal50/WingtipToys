using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WingtipToys.Application.Products.Commands;
using WingtipToys.Application.Products.Dtos;
using WingtipToys.Application.Products.Queries;

namespace WingtipToys.Api.Controllers
{
    public class ProductsController : BaseApiController
    {
        [Route("Create")]
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateProductCommand command)
        {
            return await Mediator.Send(command);
        }
        [HttpGet("{categoryId}")]
        public async Task<IList<GetProductDto>> GetProductsByCategotyId(int categoryId)
        {
            return await Mediator.Send(new GetProductsByCategotyIdQuery { CategoryID = categoryId });
        }
        [Route("GetAllProducts")]
        [HttpGet]
        public async Task<IList<GetProductDto>> GetAllProducts()
        {
            return await Mediator.Send(new GetProductsQuery());
        }
    }
}
