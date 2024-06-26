﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Discount.Dtos.CouponDtos;
using MultiShop.Discount.Services.CouponServices;

namespace MultiShop.Discount.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly ICouponService _couponService;

        public DiscountsController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpGet]
        public async Task<IActionResult> CouponList()
        {
            var values = await _couponService.GetAllCoupon();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCouponById(int id)
        {
            var values = await _couponService.GetByIdCoupon(id);
            return Ok(values);
        }

        [HttpGet("GetCodeDetailByCode")]
        public async Task<IActionResult> GetCodeDetailByCode(string code)
        {
            var values = await _couponService.GetCodeDetailByCode(code);
            return Ok(values);
        }

        [HttpGet("GetCouponRate")]
        public IActionResult GetCouponRate(string code)
        {
            var values = _couponService.GetCouponRate(code);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCoupon(CreateCouponDto createCouponDto)
        {
            await _couponService.CreateCoupon(createCouponDto);
            return Ok("Ekleme Başarılı");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteCoupon(int id)
        {
            await _couponService.DeleteCoupon(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCoupon(UpdateCouponDto updateCouponDto)
        {
            await _couponService.UpdateCoupon(updateCouponDto);
            return Ok("Güncelleme Başarılı");
        }



    }
}
