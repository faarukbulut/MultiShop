using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents._OrderPage
{
    public class _OrderPageSummaryComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
