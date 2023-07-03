using LOJA.Interface;
using LOJA.Models;
using LOJA.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LOJA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            List<Product> products = _productsRepository.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            Product product = _productsRepository.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productsRepository.AddProduct(product);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            Product existingProduct = _productsRepository.GetProduct(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Unit = product.Unit;
            existingProduct.Cost = product.Cost;
            existingProduct.Count = product.Count;
            existingProduct.SupplierId = product.SupplierId;

            _productsRepository.UpdateProduct(existingProduct);
            return Ok(existingProduct);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            Product existingProduct = _productsRepository.GetProduct(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            _productsRepository.DeleteProduct(existingProduct);
            return Ok($"Product with ID {id} deleted");
        }
    }
}
