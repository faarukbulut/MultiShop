using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.AboutDtos;
using MultiShop.WebUI.Services.CatalogServices.AboutServices;
using Newtonsoft.Json;

namespace MultiShop.WebUI.ViewComponents._DefaultLayout
{
    public class _DefaultLayoutFooterComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _DefaultLayoutFooterComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var valeus = await _aboutService.GetAllAbout();
            return View(valeus);
        }
    }
}
