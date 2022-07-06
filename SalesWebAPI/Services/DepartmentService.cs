using SalesWebAPI.Data;
using SalesWebAPI.Interfaces;
using SalesWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebAPI.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly SalesWebAPIContext _context;

        public DepartmentService(SalesWebAPIContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() //FindAll -> Async: é um padrão
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
