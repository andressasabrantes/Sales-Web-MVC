using ProjetoWebPageMVC.Data;
using ProjetoWebPageMVC.Models;

namespace ProjetoWebPageMVC.Services
{
    public class SellerService
    {
        private readonly ProjetoWebPageMVCContext _context;

        public SellerService(ProjetoWebPageMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
