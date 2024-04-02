using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.SpecialOfferServices;

namespace MultiShop.WebUI.ViewComponents._HomePage
{
    public class _HomePageSpecialOfferComponentPartial : ViewComponent
    {
        private readonly ISpecialOfferService _specialOfferService;

        public _HomePageSpecialOfferComponentPartial(ISpecialOfferService specialOfferService)
        {
            _specialOfferService = specialOfferService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _specialOfferService.GetAllSpecialOffer();
            return View(values.Take(2).ToList());
        }
    }
}
