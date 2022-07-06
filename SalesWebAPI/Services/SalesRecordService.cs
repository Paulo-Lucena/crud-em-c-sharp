using SalesWebAPI.Data;
using SalesWebAPI.Interfaces;
using SalesWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebAPI.Services
{
    public class SalesRecordService : ISalesRecordService
    {
        private readonly SalesWebAPIContext _context;

        public SalesRecordService(SalesWebAPIContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result.Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            var search = await result
              .Include(x => x.Seller)
              .Include(x => x.Seller.Department)
              .OrderByDescending(x => x.Date)
              .ToListAsync();

            return search
                .GroupBy(x => x.Seller.Department)
                .ToList(); ;
        }

    }
}
