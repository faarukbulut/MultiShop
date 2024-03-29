using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents._CartPage
{
    public class _CartPageProductListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
