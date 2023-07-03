using LOJA.Interface;
using LOJA.Models;
using LOJA.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LOJA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliersController : ControllerBase
    {
        private readonly ISuppliersRepository _suppliersRepository;

        public SuppliersController(ISuppliersRepository suppliersRepository)
        {
            _suppliersRepository = suppliersRepository;
        }

        [HttpGet]
        public IActionResult GetSuppliers()
        {
            List<Supplier> suppliers = _suppliersRepository.GetSuppliers();
            return Ok(suppliers);
        }

        [HttpGet("{id}")]
        public IActionResult GetSupplier(int id)
        {
            Supplier supplier = _suppliersRepository.GetSupplier(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return Ok(supplier);
        }

        [HttpPost]
        public IActionResult AddSupplier([FromBody] Supplier supplier)
        {
            _suppliersRepository.AddSupplier(supplier);
            return Ok(supplier);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSupplier(int id, [FromBody] Supplier supplier)
        {
            Supplier existingSupplier = _suppliersRepository.GetSupplier(id);
            if (existingSupplier == null)
            {
                return NotFound();
            }

            existingSupplier.Name = supplier.Name;
            existingSupplier.Email = supplier.Email;
            existingSupplier.Phone = supplier.Phone;
            existingSupplier.CNPJ = supplier.CNPJ;
            existingSupplier.BrandId = supplier.BrandId;

            _suppliersRepository.UpdateSupplier(existingSupplier);
            return Ok(existingSupplier);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSupplier(int id)
        {
            Supplier existingSupplier = _suppliersRepository.GetSupplier(id);
            if (existingSupplier == null)
            {
                return NotFound();
            }

            _suppliersRepository.DeleteSupplier(existingSupplier);
            return Ok($"Supplier with ID {id} deleted");
        }
    }
}
