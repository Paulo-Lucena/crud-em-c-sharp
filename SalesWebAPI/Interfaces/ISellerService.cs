using SalesWebAPI.Models;

namespace SalesWebAPI.Interfaces
{
    public interface ISellerService
    {
        List<Seller> FindAll();
        
        void Insert(Seller seller);

        Seller FindById(int id);

        void Remove(int id);
    }
}
