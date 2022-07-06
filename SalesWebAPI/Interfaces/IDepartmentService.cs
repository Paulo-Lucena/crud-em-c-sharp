using SalesWebAPI.Models;

namespace SalesWebAPI.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<Department>> FindAllAsync();

    }
}
