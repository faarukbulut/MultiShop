using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImage();
        Task CreateProductImage(CreateProductImageDto createProductImageDto);
        Task UpdateProductImage(UpdateProductImageDto updateProductImageDto);
        Task DeleteProductImage(string id);
        Task<GetByIdProductImageDto> GetByIdProductImage(string id);
    }
}
