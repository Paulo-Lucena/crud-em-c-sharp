using SalesWebAPI.Models;

namespace SalesWebAPI.Interfaces
{
    public interface ISellerService
    {
        Task<List<Seller>> FindAllAsync();
        
        Task InsertAsync(Seller seller);

        Task<Seller> FindByIdAsync(int id);

        Task RemoveAsync(int id);

        Task UpdateAsync(Seller seller); 
    }
}
