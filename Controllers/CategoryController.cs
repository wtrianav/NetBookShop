using Microsoft.AspNetCore.Mvc;

namespace NetBookShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}