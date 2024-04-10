using MultiShop.Discount.Dtos.CouponDtos;

namespace MultiShop.Discount.Services.CouponServices
{
    public interface ICouponService
    {
        Task<List<ResultCouponDto>> GetAllCoupon();
        Task CreateCoupon(CreateCouponDto createCouponDto);
        Task UpdateCoupon(UpdateCouponDto updateCouponDto);
        Task DeleteCoupon(int id);
        Task<GetByIdCouponDto> GetByIdCoupon(int id);
        Task<ResultCouponDto> GetCodeDetailByCode(string code);
        int GetCouponRate(string code);
    }
}
