using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.FeatureSliderServices;

namespace MultiShop.WebUI.ViewComponents._HomePage
{
    public class _HomePageFeatureSliderComponentPartial : ViewComponent
    {
        private readonly IFeatureSliderService _featureSliderService;

        public _HomePageFeatureSliderComponentPartial(IFeatureSliderService featureSliderService)
        {
            _featureSliderService = featureSliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureSliderService.GetAllFeatureSlider();
            return View(values);
        }
    }
}
