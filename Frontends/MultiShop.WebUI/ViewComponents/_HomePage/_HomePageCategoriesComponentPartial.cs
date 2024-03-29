using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents._HomePage
{
    public class _HomePageCategoriesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
