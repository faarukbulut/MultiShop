using MultiShop.Catalog.Dtos.BrandDtos;

namespace MultiShop.Catalog.Services.BrandServices
{
    public interface IBrandService
    {
        Task<List<ResultBrandDto>> GetAllBrand();
        Task CreateBrand(CreateBrandDto createBrandDto);
        Task UpdateBrand(UpdateBrandDto updateBrandDto);
        Task DeleteBrand(string id);
        Task<GetByIdBrandDto> GetByIdBrand(string id);
    }
}
