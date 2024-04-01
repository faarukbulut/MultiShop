using MultiShop.DtoLayer.CatalogDtos.FeatureSliderDtos;

namespace MultiShop.WebUI.Services.CatalogServices.FeatureSliderServices
{
    public interface IFeatureSliderService
    {
        Task<List<ResultFeatureSliderDto>> GetAllFeatureSlider();
        Task CreateFeatureSlider(CreateFeatureSliderDto createFeatureSliderDto);
        Task UpdateFeatureSlider(UpdateFeatureSliderDto updateFeatureSliderDto);
        Task DeleteFeatureSlider(string id);
        Task<UpdateFeatureSliderDto> GetByIdFeatureSlider(string id);
    }
}
