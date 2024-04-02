using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.CategoryServices;

namespace MultiShop.WebUI.ViewComponents._DefaultLayout
{
    public class _DefaultLayoutNavbarComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _DefaultLayoutNavbarComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategory();
            return View(values);
        }
    }
}
