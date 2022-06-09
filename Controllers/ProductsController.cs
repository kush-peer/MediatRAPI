using MediatRApi.Queries;
using MediatRApi.Commands;
using MediatRAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using MediatRApi.Models;
using MediatRApi.Notifications;
namespace MediatRApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ApiControllerBase
    {

        public ProductsController()
        {

        }

        [HttpGet(nameof(GetProducts))]
        public async Task<IActionResult> GetProducts()
        {
            var products = await Sender.Send(new GetProducts());
            return Ok(products);
        }

        [HttpGet("{id:int}",Name = "GetProductById")]
        public async Task<IActionResult> GetProductById( int id)
        {
            var products = await Sender.Send(new GetProducById(id));
            return Ok(products);
        }

        [HttpPost(nameof(AddProduct))]
        public async Task<IActionResult> AddProduct([FromBody] Product product )
        {
            var productRes = await Sender.Send(new AddProducts(product));
            await Publisher.Publish(new ProductAddedNotify(productRes));
            return CreatedAtRoute("GetProductById", new { id = productRes.Id }, productRes);
        }

    }
}
