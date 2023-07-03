using LOJA.Models;

namespace LOJA.Interface
{
    public interface IOrdersRepository
    {
        List<Order> GetOrders();
        Order GetOrder(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}