using MultiShop.DtoLayer.CatalogDtos.ProductDtos;

namespace MultiShop.WebUI.Services.CatalogServices.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProduct();
        Task CreateProduct(CreateProductDto createProductDto);
        Task UpdateProduct(UpdateProductDto updateProductDto);
        Task DeleteProduct(string id);
        Task<UpdateProductDto> GetByIdProduct(string id);
        Task<List<ResultProductWithCategoryDto>> ProductListWithCategory();
    }
}
