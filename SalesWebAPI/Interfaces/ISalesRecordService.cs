using SalesWebAPI.Models;

namespace SalesWebAPI.Interfaces
{
    public interface ISalesRecordService
    {
        Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate);
        Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate);
    }
}
