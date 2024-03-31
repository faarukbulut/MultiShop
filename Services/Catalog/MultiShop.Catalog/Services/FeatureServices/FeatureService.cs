using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.FeatureDtos;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly IMongoCollection<Feature> _collection;
        private readonly IMapper _mapper;

        public FeatureService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _collection = database.GetCollection<Feature>(_databaseSettings.FeatureCollectionName);
            _mapper = mapper;
        }

        public async Task CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var value = _mapper.Map<Feature>(createFeatureDto);
            await _collection.InsertOneAsync(value);
        }

        public async Task DeleteFeature(string id)
        {
            await _collection.DeleteOneAsync(x => x.FeatureID == id);
        }

        public async Task<List<ResultFeatureDto>> GetAllFeature()
        {
            var values = await _collection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultFeatureDto>>(values);
        }

        public async Task<GetByIdFeatureDto> GetByIdFeature(string id)
        {
            var values = await _collection.Find<Feature>(x => x.FeatureID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdFeatureDto>(values);
        }

        public async Task UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var values = _mapper.Map<Feature>(updateFeatureDto);
            await _collection.FindOneAndReplaceAsync(x => x.FeatureID == updateFeatureDto.FeatureID, values);
        }
    }
}
