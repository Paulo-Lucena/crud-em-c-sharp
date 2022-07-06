using SalesWebAPI.Models;

namespace SalesWebAPI.Interfaces
{
    public interface ISalesRecordService
    {
       Task <List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate);
    }
}
