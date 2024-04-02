using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.BrandServices;

namespace MultiShop.WebUI.ViewComponents._HomePage
{
    public class _HomePageBrandComponentPartial : ViewComponent
    {
        private readonly IBrandService _brandService;

        public _HomePageBrandComponentPartial(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _brandService.GetAllBrand();
            return View(values);
        }
    }
}
