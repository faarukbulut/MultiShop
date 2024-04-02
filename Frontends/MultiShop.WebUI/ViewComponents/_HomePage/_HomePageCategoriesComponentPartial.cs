using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.CategoryServices;

namespace MultiShop.WebUI.ViewComponents._HomePage
{
    public class _HomePageCategoriesComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _HomePageCategoriesComponentPartial(ICategoryService categoryService)
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
