using ProjetoWebPageMVC.Data;
using ProjetoWebPageMVC.Models;

namespace ProjetoWebPageMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjetoWebPageMVCContext _context;

        public DepartmentService(ProjetoWebPageMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
