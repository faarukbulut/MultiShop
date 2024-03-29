using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents._HomePage
{
    public class _HomePageOfferDiscountComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
