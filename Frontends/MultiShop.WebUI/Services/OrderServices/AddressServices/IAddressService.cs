using MultiShop.DtoLayer.OrderDtos.AddressDtos;

namespace MultiShop.WebUI.Services.OrderServices.AddressServices
{
    public interface IAddressService
    {
        //Task<List<ResultAddressDto>> GetAllAddress();
        Task CreateAddress(CreateAddressDto createAddressDto);
        //Task UpdateAddress(UpdateAddressDto updateAddressDto);
        //Task DeleteAddress(string id);
        //Task<UpdateAddressDto> GetByIdAddress(string id);
    }
}
