using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.CategoryID = id;
            return View();
        }

        public IActionResult Detail(string id)
        {
            ViewBag.ProductID = id;
            return View();
        }
    }
}
