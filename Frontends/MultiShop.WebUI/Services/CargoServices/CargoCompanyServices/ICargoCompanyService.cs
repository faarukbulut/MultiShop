using MultiShop.DtoLayer.CargoDtos.CargoCompanyDtos;

namespace MultiShop.WebUI.Services.CargoServices.CargoCompanyServices
{
    public interface ICargoCompanyService
    {
        Task<List<ResultCargoCompanyDto>> GetAllCargoCompany();
        Task CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto);
        Task UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto);
        Task DeleteCargoCompany(int id);
        Task<UpdateCargoCompanyDto> GetByIdCargoCompany(int id);
    }
}
