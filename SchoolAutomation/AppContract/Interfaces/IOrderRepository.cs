using AppEntity.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppContract.Interfaces
{
    public interface IOrderRepository
    {
        Task<int> SaveOrder(Order order);
        Task<List<Order>> GetOrders();
    }
}