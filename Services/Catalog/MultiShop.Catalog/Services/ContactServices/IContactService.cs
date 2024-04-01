using MultiShop.Catalog.Dtos.ContactDtos;

namespace MultiShop.Catalog.Services.ContactServices
{
    public interface IContactService
    {
        Task<List<ResultContactDto>> GetAllContact();
        Task CreateContact(CreateContactDto createContactDto);
        Task UpdateContact(UpdateContactDto updateContactDto);
        Task DeleteContact(string id);
        Task<GetByIdContactDto> GetByIdContact(string id);
    }
}
