﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Services.ProductDetailServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailService _ProductDetailService;

        public ProductDetailsController(IProductDetailService ProductDetailService)
        {
            _ProductDetailService = ProductDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductDetailList()
        {
            var values = await _ProductDetailService.GetAllProductDetail();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailById(string id)
        {
            var values = await _ProductDetailService.GetByIdProductDetail(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
        {
            await _ProductDetailService.CreateProductDetail(createProductDetailDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductDetail(string id)
        {
            await _ProductDetailService.DeleteProductDetail(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
        {
            await _ProductDetailService.UpdateProductDetail(updateProductDetailDto);
            return Ok("Güncelleme Başarılı");
        }
    }
}
