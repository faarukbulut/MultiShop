using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;

namespace MultiShop.WebUI.ViewComponents._HomePage
{
    public class _HomePageFeaturedProductsComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _HomePageFeaturedProductsComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProduct();
            return View(values);
        }
    }
}
