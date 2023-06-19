using Microsoft.AspNetCore.Mvc;

namespace LOJA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            // Lógica para obter uma lista de produtos do banco de dados
            return Ok("Lista de produtos");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            // Lógica para obter um produto específico por ID do banco de dados
            return Ok($"Produto com ID {id}");
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductDTO product)
        {
            // Lógica para adicionar um novo produto ao banco de dados
            return Ok($"Novo produto adicionado: {product.Name}");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductDTO product)
        {
            // Lógica para atualizar um produto existente no banco de dados com base no ID
            return Ok($"Produto com ID {id} atualizado: {product.Name}");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            // Lógica para excluir um produto do banco de dados com base no ID
            return Ok($"Produto com ID {id} excluído");
        }
    }

    public class ProductDTO
    {
        public string Name { get; set; }
        // Outras propriedades do produto
    }
}