using Microsoft.AspNetCore.Mvc;
using NetBookShop.Data;
using NetBookShop.Models;

namespace NetBookShop.Controllers
{
    public class CategoryController : Controller
    {
        // Read of my categories
        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        // Basic view of category index page
        public IActionResult Index()
        {
            // var categoryList = _db.Categories.ToList();
            IEnumerable<Category> categoryList = _db.Categories;
            return View(categoryList);
        }
    }
}