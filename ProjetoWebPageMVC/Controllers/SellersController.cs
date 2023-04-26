using Microsoft.AspNetCore.Mvc;

namespace ProjetoWebPageMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
