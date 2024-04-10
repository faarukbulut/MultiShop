using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents._OrderPage
{
    public class _OrderPageDetailComponentPartial : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
