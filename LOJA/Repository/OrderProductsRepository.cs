using System.Collections.Generic;
using System.Linq;
using LOJA.Data;
using LOJA.Models;
using LOJA.Interface;

namespace LOJA.Repositories
{
    public class OrderProductsRepository : IOrderProductsRepository
    {
        private readonly AppDbContext _dbContext;

        public OrderProductsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<OrderProduct> GetOrderProducts()
        {
            return _dbContext.OrderProducts.ToList();
        }

        public OrderProduct GetOrderProduct(int id)
        {
            return _dbContext.OrderProducts.Find(id);
        }

        public void AddOrderProduct(OrderProduct orderProduct)
        {
            _dbContext.OrderProducts.Add(orderProduct);
            _dbContext.SaveChanges();
        }

        public void UpdateOrderProduct(OrderProduct orderProduct)
        {
            _dbContext.OrderProducts.Update(orderProduct);
            _dbContext.SaveChanges();
        }

        public void DeleteOrderProduct(OrderProduct orderProduct)
        {
            _dbContext.OrderProducts.Remove(orderProduct);
            _dbContext.SaveChanges();
        }
    }
}
