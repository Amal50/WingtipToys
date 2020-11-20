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
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateProductCommand command)
        {
            return await Mediator.Send(command);
        }
        [HttpGet("{id}")]
        public async Task<IList<GetProductDto>> GetProductsByCategotyId(int id)
        {
            return await Mediator.Send(new GetProductsByCategotyIdQuery { CategoryID =  id});
        }
    }
}
