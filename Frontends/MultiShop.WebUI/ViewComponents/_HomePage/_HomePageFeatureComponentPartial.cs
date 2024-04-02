using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.FeatureServices;

namespace MultiShop.WebUI.ViewComponents._HomePage
{
    public class _HomePageFeatureComponentPartial : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _HomePageFeatureComponentPartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.GetAllFeature();
            return View(values);
        }
    }
}
