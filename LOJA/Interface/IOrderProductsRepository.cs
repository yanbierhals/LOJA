using LOJA.Models;
using System.Collections.Generic;

namespace LOJA.Interface
{
    public interface IOrderProductsRepository
    {
        List<OrderProduct> GetOrderProducts();
        OrderProduct GetOrderProduct(int id);
        void AddOrderProduct(OrderProduct orderProduct);
        void UpdateOrderProduct(OrderProduct orderProduct);
        void DeleteOrderProduct(OrderProduct orderProduct);
    }
}