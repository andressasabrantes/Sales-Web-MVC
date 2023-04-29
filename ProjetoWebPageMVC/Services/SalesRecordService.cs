using ProjetoWebPageMVC.Data;
using ProjetoWebPageMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoWebPageMVC.Services
{
    public class SalesRecordService
    {
        private readonly ProjetoWebPageMVCContext _context;

        public SalesRecordService(ProjetoWebPageMVCContext context)
        {
            _context = context;
        }

        public List<SalesRecord> FindByDate(DateTime? minDate,  DateTime? maxDate)
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
            return result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToList();
        }
    }
}
