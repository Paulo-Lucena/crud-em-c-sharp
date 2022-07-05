using SalesWebAPI.Data;
using SalesWebAPI.Interfaces;
using SalesWebAPI.Models;

namespace SalesWebAPI.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly SalesWebAPIContext _context;

        public DepartmentService(SalesWebAPIContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
