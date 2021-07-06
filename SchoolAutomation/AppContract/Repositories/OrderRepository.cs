using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppContract.Interfaces;
using AppEntity.Database;
using AppEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace AppContract.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbEntities _entities;

        public OrderRepository(DbEntities entities)
        {
            _entities = entities;
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _entities.Orders
                .Include(x => x.Product)
                .ThenInclude(x => x.Department)
                .OrderByDescending(x => x.OrderId)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> SaveOrder(Order order)
        {
            await _entities.Orders.AddAsync(order);
            return await _entities.SaveChangesAsync();
        }
    }
}