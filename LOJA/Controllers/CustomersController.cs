using Microsoft.AspNetCore.Mvc;

namespace LOJA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCustomers()
        {
            // Lógica para obter uma lista de clientes do banco de dados
            return Ok("Lista de clientes");
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            // Lógica para obter um cliente específico por ID do banco de dados
            return Ok($"Cliente com ID {id}");
        }

        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerDTO customer)
        {
            // Lógica para adicionar um novo cliente ao banco de dados
            return Ok($"Novo cliente adicionado: {customer.Name}");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, [FromBody] CustomerDTO customer)
        {
            // Lógica para atualizar um cliente existente no banco de dados com base no ID
            return Ok($"Cliente com ID {id} atualizado: {customer.Name}");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            // Lógica para excluir um cliente do banco de dados com base no ID
            return Ok($"Cliente com ID {id} excluído");
        }
    }

    public class CustomerDTO
    {
        public string Name { get; set; }
        // Outras propriedades do cliente
    }
}