using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents._DefaultLayout
{
    public class _DefaultLayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
