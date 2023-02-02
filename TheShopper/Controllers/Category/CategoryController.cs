using Microsoft.AspNetCore.Mvc;
using TheShopper.Data;
using TheShopper.Models;

namespace TheShopper.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AplicationDbContext _db;

        public CategoryController(AplicationDbContext db)
        {
            _db = db;
        }       

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
