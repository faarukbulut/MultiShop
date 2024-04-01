using MultiShop.DtoLayer.CatalogDtos.AboutDtos;

namespace MultiShop.WebUI.Services.CatalogServices.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAbout();
        Task CreateAbout(CreateAboutDto createAboutDto);
        Task UpdateAbout(UpdateAboutDto updateAboutDto);
        Task DeleteAbout(string id);
        Task<UpdateAboutDto> GetByIdAbout(string id);
    }
}
