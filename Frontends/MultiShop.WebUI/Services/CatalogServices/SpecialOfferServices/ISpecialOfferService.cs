using MultiShop.DtoLayer.CatalogDtos.SpecialOfferDtos;

namespace MultiShop.WebUI.Services.CatalogServices.SpecialOfferServices
{
    public interface ISpecialOfferService
    {
        Task<List<ResultSpecialOfferDto>> GetAllSpecialOffer();
        Task CreateSpecialOffer(CreateSpecialOfferDto createSpecialOfferDto);
        Task UpdateSpecialOffer(UpdateSpecialOfferDto updateSpecialOfferDto);
        Task DeleteSpecialOffer(string id);
        Task<UpdateSpecialOfferDto> GetByIdSpecialOffer(string id);
    }
}
