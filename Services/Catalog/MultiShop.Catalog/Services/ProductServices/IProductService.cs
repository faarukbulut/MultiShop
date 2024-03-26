using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProduct();
        Task CreateProduct(CreateProductDto createProductDto);
        Task UpdateProduct(UpdateProductDto updateProductDto);
        Task DeleteProduct(string id);
        Task<GetByIdProductDto> GetByIdProduct(string id);
    }
}
