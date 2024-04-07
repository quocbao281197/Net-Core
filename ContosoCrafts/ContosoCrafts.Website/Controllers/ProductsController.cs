using ContosoCrafts.Website.Models;
using ContosoCrafts.Website.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.Website.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductService _productService { get; set; }
        public IEnumerable<Product> Products { get; private set; }

        public ProductsController(JsonFileProductService productService)
        {
            this._productService = productService;   
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return this._productService.GetProducts();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery]string productId, [FromQuery] int rating)
        {
            _productService.AddRating(productId, rating);
            return Ok();
        }
    }
}
