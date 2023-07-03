using System.Collections.Generic;
using LOJA.Models;

namespace LOJA.Interface
{
    public interface ICustomersRepository
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
