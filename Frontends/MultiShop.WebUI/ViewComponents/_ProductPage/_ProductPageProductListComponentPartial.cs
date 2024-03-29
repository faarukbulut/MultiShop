using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents._ProductPage
{
    public class _ProductPageProductListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
