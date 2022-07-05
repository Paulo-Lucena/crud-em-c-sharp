using SalesWebAPI.Data;
using SalesWebAPI.Interfaces;
using SalesWebAPI.Models;

namespace SalesWebAPI.Services
{
    public class SellerService : ISellerService
    {

        private readonly SalesWebAPIContext _context;

        public SellerService(SalesWebAPIContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }

    }
}
