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

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
