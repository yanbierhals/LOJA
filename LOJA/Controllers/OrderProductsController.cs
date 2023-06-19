using Microsoft.AspNetCore.Mvc;

namespace LOJA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrderProducts()
        {
            // Lógica para obter uma lista de produtos do pedido do banco de dados
            return Ok("Lista de produtos do pedido");
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderProduct(int id)
        {
            // Lógica para obter um produto do pedido específico por ID do banco de dados
            return Ok($"Produto do pedido com ID {id}");
        }

        [HttpPost]
        public IActionResult AddOrderProduct([FromBody] OrderProductDTO orderProduct)
        {
            // Lógica para adicionar um novo produto ao pedido no banco de dados
            return Ok($"Novo produto adicionado ao pedido: {orderProduct.ProductName}");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrderProduct(int id, [FromBody] OrderProductDTO orderProduct)
        {
            // Lógica para atualizar um produto existente no pedido no banco de dados com base no ID
            return Ok($"Produto do pedido com ID {id} atualizado: {orderProduct.ProductName}");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderProduct(int id)
        {
            // Lógica para excluir um produto do pedido do banco de dados com base no ID
            return Ok($"Produto do pedido com ID {id} excluído");
        }
    }

    public class OrderProductDTO
    {
        public string ProductName { get; set; }
        // Outras propriedades do produto do pedido
    }
}