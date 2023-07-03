using LOJA.Interface;
using LOJA.Models;
using LOJA.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LOJA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersController(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            List<Customer> customers = _customersRepository.GetCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            Customer customer = _customersRepository.GetCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerDTO customerDTO)
        {
            Customer customer = new Customer
            {
                Name = customerDTO.Name,
                Email = customerDTO.Email,
                Phone = customerDTO.Phone,
                CPF = customerDTO.CPF,
                CNPJ = customerDTO.CNPJ
            };

            _customersRepository.AddCustomer(customer);
            return Ok($"Novo cliente adicionado: {customer.Name}");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, [FromBody] CustomerDTO customerDTO)
        {
            Customer existingCustomer = _customersRepository.GetCustomer(id);
            if (existingCustomer == null)
            {
                return NotFound();
            }

            existingCustomer.Name = customerDTO.Name;
            existingCustomer.Email = customerDTO.Email;
            existingCustomer.Phone = customerDTO.Phone;
            existingCustomer.CPF = customerDTO.CPF;
            existingCustomer.CNPJ = customerDTO.CNPJ;

            _customersRepository.UpdateCustomer(existingCustomer);
            return Ok($"Cliente com ID {id} atualizado: {existingCustomer.Name}");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            Customer existingCustomer = _customersRepository.GetCustomer(id);
            if (existingCustomer == null)
            {
                return NotFound();
            }

            _customersRepository.DeleteCustomer(existingCustomer);
            return Ok($"Cliente com ID {id} excluído");
        }
    }

    public class CustomerDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? CPF { get; set; }
        public string? CNPJ { get; set; }
    }
} 