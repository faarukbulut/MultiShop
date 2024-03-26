using MultiShop.Catalog.Dtos.ProductDetailDtos;

namespace MultiShop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDetailDto>> GetAllProductDetail();
        Task CreateProductDetail(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductDetail(string id);
        Task<GetByIdProductDetailDto> GetByIdProductDetail(string id);
    }
}
