using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppContract.Interfaces;
using AppEntity.Database;
using AppEntity.Models;
using Microsoft.EntityFrameworkCore;


namespace AppContract.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbEntities _entities;

        public ProductRepository(DbEntities entities)
        {
            _entities = entities;
        }

        public async Task<List<Product>> GetProducts(int departmentId)
        {
            return await _entities.Products
                .Where(x => x.DepartmentId == departmentId)
                .Where(x => x.IsActive == "Y")
                .AsNoTracking()
                .OrderBy(x => x.Name)
                .ToListAsync();
        }
    }
}