using MultiShop.Catalog.Dtos.FeatureSliderDtos;

namespace MultiShop.Catalog.Services.FeatureSliderServices
{
    public interface IFeatureSliderService
    {
        Task<List<ResultFeatureSliderDto>> GetAllFeatureSlider();
        Task CreateFeatureSlider(CreateFeatureSliderDto createFeatureSliderDto);
        Task UpdateFeatureSlider(UpdateFeatureSliderDto updateFeatureSliderDto);
        Task DeleteFeatureSlider(string id);
        Task<GetByIdFeatureSliderDto> GetByIdFeatureSlider(string id);
        Task FeatureSliderChangeStatus(string id, bool status);
    }
}
