using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.BrandDtos;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.BrandServices
{
    public class BrandService : IBrandService
    {
        private readonly IMongoCollection<Brand> _collection;
        private readonly IMapper _mapper;

        public BrandService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _collection = database.GetCollection<Brand>(_databaseSettings.BrandCollectionName);
            _mapper = mapper;
        }

        public async Task CreateBrand(CreateBrandDto createBrandDto)
        {
            var value = _mapper.Map<Brand>(createBrandDto);
            await _collection.InsertOneAsync(value);
        }

        public async Task DeleteBrand(string id)
        {
            await _collection.DeleteOneAsync(x => x.BrandID == id);
        }

        public async Task<List<ResultBrandDto>> GetAllBrand()
        {
            var values = await _collection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultBrandDto>>(values);
        }

        public async Task<GetByIdBrandDto> GetByIdBrand(string id)
        {
            var values = await _collection.Find<Brand>(x => x.BrandID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdBrandDto>(values);
        }

        public async Task UpdateBrand(UpdateBrandDto updateBrandDto)
        {
            var values = _mapper.Map<Brand>(updateBrandDto);
            await _collection.FindOneAndReplaceAsync(x => x.BrandID == updateBrandDto.BrandID, values);
        }
    }
}
