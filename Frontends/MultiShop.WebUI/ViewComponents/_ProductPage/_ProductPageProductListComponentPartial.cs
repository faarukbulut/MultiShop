using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;

namespace MultiShop.WebUI.ViewComponents._ProductPage
{
    public class _ProductPageProductListComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductPageProductListComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var values = await _productService.ProductListWithCategoryByCategoryId(id);
            return View(values);
        }
    }
}
