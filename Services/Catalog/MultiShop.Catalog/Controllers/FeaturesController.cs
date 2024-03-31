using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.FeatureDtos;
using MultiShop.Catalog.Services.FeatureServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _featureService;

        public FeaturesController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet]
        public async Task<IActionResult> FeatureList()
        {
            var values = await _featureService.GetAllFeature();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureById(string id)
        {
            var values = await _featureService.GetByIdFeature(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            await _featureService.CreateFeature(createFeatureDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFeature(string id)
        {
            await _featureService.DeleteFeature(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            await _featureService.UpdateFeature(updateFeatureDto);
            return Ok("Güncelleme Başarılı");
        }
    }
}
