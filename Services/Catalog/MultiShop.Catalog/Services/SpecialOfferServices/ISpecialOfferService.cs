using MultiShop.Catalog.Dtos.SpecialOfferDtos;

namespace MultiShop.Catalog.Services.SpecialOfferServices
{
    public interface ISpecialOfferService
    {
        Task<List<ResultSpecialOfferDto>> GetAllSpecialOffer();
        Task CreateSpecialOffer(CreateSpecialOfferDto createSpecialOfferDto);
        Task UpdateSpecialOffer(UpdateSpecialOfferDto updateSpecialOfferDto);
        Task DeleteSpecialOffer(string id);
        Task<GetByIdSpecialOfferDto> GetByIdSpecialOffer(string id);
    }
}
