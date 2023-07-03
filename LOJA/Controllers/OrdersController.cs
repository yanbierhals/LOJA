using LOJA.Interface;
using LOJA.Models;
using LOJA.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LOJA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersController(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            List<Order> orders = _ordersRepository.GetOrders();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            Order order = _ordersRepository.GetOrder(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody] Order order)
        {
            _ordersRepository.AddOrder(order);
            return Ok(order);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, [FromBody] Order order)
        {
            Order existingOrder = _ordersRepository.GetOrder(id);
            if (existingOrder == null)
            {
                return NotFound();
            }

            existingOrder.TotalDue = order.TotalDue;
            existingOrder.OrderStatus = order.OrderStatus;

            _ordersRepository.UpdateOrder(existingOrder);
            return Ok(existingOrder);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            Order existingOrder = _ordersRepository.GetOrder(id);
            if (existingOrder == null)
            {
                return NotFound();
            }

            _ordersRepository.DeleteOrder(existingOrder);
            return Ok($"Order with ID {id} deleted");
        }
    }
}
