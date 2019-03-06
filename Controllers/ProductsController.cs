using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;

namespace Supermarket.API.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class ProductsController : Controller
    {
        protected readonly IProductService _producService;

        public ProductsController(IProductService producService)
        {
            this._producService = producService;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = await _producService.ListAsync();
            return products;
        }

    }
}