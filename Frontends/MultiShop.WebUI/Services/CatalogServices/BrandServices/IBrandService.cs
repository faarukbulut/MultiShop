using MultiShop.DtoLayer.CatalogDtos.BrandDtos;

namespace MultiShop.WebUI.Services.CatalogServices.BrandServices
{
    public interface IBrandService
    {
        Task<List<ResultBrandDto>> GetAllBrand();
        Task CreateBrand(CreateBrandDto createBrandDto);
        Task UpdateBrand(UpdateBrandDto updateBrandDto);
        Task DeleteBrand(string id);
        Task<UpdateBrandDto> GetByIdBrand(string id);
    }
}
