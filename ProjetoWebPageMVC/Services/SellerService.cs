using Microsoft.EntityFrameworkCore;
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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById (int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
