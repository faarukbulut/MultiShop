using MultiShop.DtoLayer.CargoDtos.CargoCompanyDtos;

namespace MultiShop.WebUI.Services.CargoServices.CargoCompanyServices
{
    public class CargoCompanyService : ICargoCompanyService
    {
        private readonly HttpClient _httpClient;

        public CargoCompanyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
        {
            await _httpClient.PostAsJsonAsync<CreateCargoCompanyDto>("cargocompanies", createCargoCompanyDto);
        }

        public async Task DeleteCargoCompany(string id)
        {
            await _httpClient.DeleteAsync("cargocompanies?id=" + id);
        }

        public async Task<List<ResultCargoCompanyDto>> GetAllCargoCompany()
        {
            var responseMessage = await _httpClient.GetAsync("cargocompanies");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultCargoCompanyDto>>();
            return values;
        }

        public async Task<UpdateCargoCompanyDto> GetByIdCargoCompany(string id)
        {
            var responseMessage = await _httpClient.GetAsync("cargocompanies/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<UpdateCargoCompanyDto>();
            return values;
        }

        public async Task UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateCargoCompanyDto>("cargocompanies", updateCargoCompanyDto);
        }
    }
}
