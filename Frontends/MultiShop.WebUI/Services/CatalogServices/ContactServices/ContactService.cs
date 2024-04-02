using MultiShop.DtoLayer.CatalogDtos.ContactDtos;

namespace MultiShop.WebUI.Services.CatalogServices.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly HttpClient _httpClient;

        public ContactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateContact(CreateContactDto createContactDto)
        {
            await _httpClient.PostAsJsonAsync<CreateContactDto>("contacts", createContactDto);
        }

        public async Task DeleteContact(string id)
        {
            await _httpClient.DeleteAsync("contacts?id=" + id);
        }

        public async Task<List<ResultContactDto>> GetAllContact()
        {
            var responseMessage = await _httpClient.GetAsync("contacts");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultContactDto>>();
            return values;
        }

        public async Task<UpdateContactDto> GetByIdContact(string id)
        {
            var responseMessage = await _httpClient.GetAsync("contacts/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<UpdateContactDto>();
            return values;
        }

        public async Task UpdateContact(UpdateContactDto updateContactDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateContactDto>("contacts", updateContactDto);
        }
    }
}
