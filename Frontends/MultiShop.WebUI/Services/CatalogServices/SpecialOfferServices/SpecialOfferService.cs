using MultiShop.DtoLayer.CatalogDtos.SpecialOfferDtos;

namespace MultiShop.WebUI.Services.CatalogServices.SpecialOfferServices
{
    public class SpecialOfferService : ISpecialOfferService
    {
        private readonly HttpClient _httpClient;

        public SpecialOfferService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateSpecialOffer(CreateSpecialOfferDto createSpecialOfferDto)
        {
            await _httpClient.PostAsJsonAsync<CreateSpecialOfferDto>("specialoffers", createSpecialOfferDto);
        }

        public async Task DeleteSpecialOffer(string id)
        {
            await _httpClient.DeleteAsync("specialoffers?id=" + id);
        }

        public async Task<List<ResultSpecialOfferDto>> GetAllSpecialOffer()
        {
            var responseMessage = await _httpClient.GetAsync("specialoffers");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultSpecialOfferDto>>();
            return values;
        }

        public async Task<UpdateSpecialOfferDto> GetByIdSpecialOffer(string id)
        {
            var responseMessage = await _httpClient.GetAsync("specialoffers/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<UpdateSpecialOfferDto>();
            return values;
        }

        public async Task UpdateSpecialOffer(UpdateSpecialOfferDto updateSpecialOfferDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateSpecialOfferDto>("specialoffers", updateSpecialOfferDto);
        }
    }
}
