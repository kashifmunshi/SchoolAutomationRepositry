using System.Collections.Generic;
using System.Threading.Tasks;
using AppEntity.Models;


namespace AppContract.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts(int departmentId);
    }
}