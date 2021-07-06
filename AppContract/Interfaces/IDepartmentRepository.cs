using System.Collections.Generic;
using System.Threading.Tasks;
using AppEntity.Models;

namespace AppContract.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetDepartments();
    }
}