using Microsoft.AspNetCore.Mvc;

namespace LOJA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSuppliers()
        {
            // Lógica para obter uma lista de fornecedores do banco de dados
            return Ok("Lista de fornecedores");
        }

        [HttpGet("{id}")]
        public IActionResult GetSupplier(int id)
        {
            // Lógica para obter um fornecedor específico por ID do banco de dados
            return Ok($"Fornecedor com ID {id}");
        }

        [HttpPost]
        public IActionResult AddSupplier([FromBody] SupplierDTO supplier)
        {
            // Lógica para adicionar um novo fornecedor ao banco de dados
            return Ok($"Novo fornecedor adicionado: {supplier.Name}");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSupplier(int id, [FromBody] SupplierDTO supplier)
        {
            // Lógica para atualizar um fornecedor existente no banco de dados com base no ID
            return Ok($"Fornecedor com ID {id} atualizado: {supplier.Name}");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSupplier(int id)
        {
            // Lógica para excluir um fornecedor do banco de dados com base no ID
            return Ok($"Fornecedor com ID {id} excluído");
        }
    }

    public class SupplierDTO
    {
        public string Name { get; set; }
        // Outras propriedades do fornecedor
    }
}