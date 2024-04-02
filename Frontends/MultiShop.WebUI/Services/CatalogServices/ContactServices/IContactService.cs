using MultiShop.DtoLayer.CatalogDtos.ContactDtos;

namespace MultiShop.WebUI.Services.CatalogServices.ContactServices
{
    public interface IContactService
    {
        Task<List<ResultContactDto>> GetAllContact();
        Task CreateContact(CreateContactDto createContactDto);
        Task UpdateContact(UpdateContactDto updateContactDto);
        Task DeleteContact(string id);
        Task<UpdateContactDto> GetByIdContact(string id);
    }
}
