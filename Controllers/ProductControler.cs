using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace PdIwtA_1a.ASP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> _products = new List<Product>
        {
            new Product(Guid.NewGuid(), "Ananas", true),
            new Product(Guid.NewGuid(), "Banan", false),
            new Product(Guid.NewGuid(), "Kiwi", true)
        };

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        [HttpGet("[action]")]
        public IActionResult Get(Guid id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if (product is null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost("[action]")]
        public void Add(Product product)
        {
            _products.Add(product);
        }

        [HttpPut("action")]
        public IActionResult Update(Product product)
        {
            var produktid = _products.FindIndex(x => x.Id == product.Id);

            if (product is null)
                return NotFound();

            return Ok(product);
        }

        [HttpDelete("[action]")]
        public IActionResult Delete(Guid id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if (product is null)
                return NotFound();

            _products.Remove(product);
            return Ok();
        }
    }
}
