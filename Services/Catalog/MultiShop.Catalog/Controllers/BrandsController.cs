using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.BrandDtos;
using MultiShop.Catalog.Services.BrandServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _BrandService;

        public BrandsController(IBrandService BrandService)
        {
            _BrandService = BrandService;
        }

        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var values = await _BrandService.GetAllBrand();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(string id)
        {
            var values = await _BrandService.GetByIdBrand(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandDto createBrandDto)
        {
            await _BrandService.CreateBrand(createBrandDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBrand(string id)
        {
            await _BrandService.DeleteBrand(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandDto updateBrandDto)
        {
            await _BrandService.UpdateBrand(updateBrandDto);
            return Ok("Güncelleme Başarılı");
        }
    }
}
