using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public class ProductImageService : IProductImageService
    {
        private readonly IMongoCollection<ProductImage> _collection;
        private readonly IMapper _mapper;

        public ProductImageService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _collection = database.GetCollection<ProductImage>(_databaseSettings.ProductImageCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            var value = _mapper.Map<ProductImage>(createProductImageDto);
            await _collection.InsertOneAsync(value);
        }

        public async Task DeleteProductImage(string id)
        {
            await _collection.DeleteOneAsync(x => x.ProductImageID == id);
        }

        public async Task<List<ResultProductImageDto>> GetAllProductImage()
        {
            var values = await _collection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductImageDto>>(values);
        }

        public async Task<GetByIdProductImageDto> GetByIdProductImage(string id)
        {
            var values = await _collection.Find<ProductImage>(x => x.ProductImageID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductImageDto>(values);
        }

        public async Task UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {
            var values = _mapper.Map<ProductImage>(updateProductImageDto);
            await _collection.FindOneAndReplaceAsync(x => x.ProductImageID == updateProductImageDto.ProductImageID, values);
        }
    }
}
