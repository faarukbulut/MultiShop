using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.BasketDtos;
using MultiShop.WebUI.Services.BasketServices;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;

namespace MultiShop.WebUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBasketService _basketService;

        public ShoppingCartController(IProductService productService, IBasketService basketService)
        {
            _productService = productService;
            _basketService = basketService;
        }

        public async Task<IActionResult> Index(string code, int discountRate)
        {
            ViewBag.Code = code;
            ViewBag.DiscountRate = discountRate;

            var values = await _basketService.GetBasket();
            ViewBag.TotalPrice = values.TotalPrice;
            ViewBag.TaxPrice = values.TotalPrice / 100 * 20;
            ViewBag.TotalPriceWithTax = values.TotalPrice + values.TotalPrice / 100 * 20;

            return View();
        }

        public async Task<IActionResult> AddBasketItem(string id)
        {
            var values = await _productService.GetByIdProduct(id);
            var items = new BasketItemDto
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductImage = values.ProductImage1,
                Price = values.ProductPrice,
                Quantity = 1
            };

            await _basketService.AddBasketItem(items);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveBasketItem(string id)
        {
            await _basketService.RemoveBasketItem(id);
            return RedirectToAction("Index");
        }

    }
}
