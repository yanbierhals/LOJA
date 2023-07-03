using System.Collections.Generic;
using System.Linq;
using LOJA.Data;
using LOJA.Interface;
using LOJA.Models; // Importe o namespace do seu contexto do banco de dados

namespace LOJA.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly AppDbContext _dbContext;

        public CustomersRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            return _dbContext.Customers.Find(id);
        }

        public void AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
        }
    }
}
