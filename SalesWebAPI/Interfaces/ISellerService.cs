using SalesWebAPI.Models;

namespace SalesWebAPI.Interfaces
{
    public interface ISellerService
    {

        List<Seller> FindAll();
    }
}
