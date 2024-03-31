using MultiShop.Catalog.Dtos.FeatureDtos;

namespace MultiShop.Catalog.Services.FeatureServices
{
    public interface IFeatureService
    {
        Task<List<ResultFeatureDto>> GetAllFeature();
        Task CreateFeature(CreateFeatureDto createFeatureDto);
        Task UpdateFeature(UpdateFeatureDto updateFeatureDto);
        Task DeleteFeature(string id);
        Task<GetByIdFeatureDto> GetByIdFeature(string id);
    }
}
