using MultiShop.Catalog.Dtos.AboutDtos;

namespace MultiShop.Catalog.Services.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAbout();
        Task CreateAbout(CreateAboutDto createAboutDto);
        Task UpdateAbout(UpdateAboutDto updateAboutDto);
        Task DeleteAbout(string id);
        Task<GetByIdAboutDto> GetByIdAbout(string id);
    }
}
