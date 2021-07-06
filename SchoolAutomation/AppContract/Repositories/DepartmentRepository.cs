using AppContract.Interfaces;
using AppEntity.Database;
using AppEntity.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppContract.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DbEntities _entities;

        public DepartmentRepository(DbEntities entities)
        {
            _entities = entities;
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await _entities.Departments
                .Where(x=>x.IsActive=="Y")
                .AsNoTracking()
                .OrderBy(x => x.Name)
                .ToListAsync();
        }
    }
}