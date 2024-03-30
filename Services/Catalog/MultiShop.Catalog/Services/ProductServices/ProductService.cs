using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _collection;
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;


        public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _collection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            var value = _mapper.Map<Product>(createProductDto);
            await _collection.InsertOneAsync(value);
        }

        public async Task DeleteProduct(string id)
        {
            await _collection.DeleteOneAsync(x => x.ProductID == id);
        }

        public async Task<List<ResultProductDto>> GetAllProduct()
        {
            var values = await _collection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<GetByIdProductDto> GetByIdProduct(string id)
        {
            var values = await _collection.Find<Product>(x => x.ProductID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductDto>(values);
        }

        public async Task UpdateProduct(UpdateProductDto updateProductDto)
        {
            var values = _mapper.Map<Product>(updateProductDto);
            await _collection.FindOneAndReplaceAsync(x => x.ProductID == updateProductDto.ProductID, values);
        }

        public async Task<List<ResultProductWithCategoryDto>> GetProductWithCategory()
        {
            var values = await _collection.Find(x => true).ToListAsync();
            foreach(var item in values)
            {
                item.Category = await _categoryCollection.Find<Category>(x => x.CategoryID == item.CategoryID).FirstAsync();
            }

            return _mapper.Map<List<ResultProductWithCategoryDto>>(values);
        }

    }
}
