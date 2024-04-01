using MultiShop.DtoLayer.CatalogDtos.FeatureDtos;

namespace MultiShop.WebUI.Services.CatalogServices.FeatureServices
{
    public interface IFeatureService
    {
        Task<List<ResultFeatureDto>> GetAllFeature();
        Task CreateFeature(CreateFeatureDto createFeatureDto);
        Task UpdateFeature(UpdateFeatureDto updateFeatureDto);
        Task DeleteFeature(string id);
        Task<UpdateFeatureDto> GetByIdFeature(string id);
    }
}
