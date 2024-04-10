using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.OrderDtos.AddressDtos;
using MultiShop.WebUI.Services.Abstract;
using MultiShop.WebUI.Services.OrderServices.AddressServices;

namespace MultiShop.WebUI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAddressService _addressService;
        private readonly IUserService _userService;

        public OrderController(IAddressService addressService, IUserService userService)
        {
            _addressService = addressService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateAddressDto createAddressDto)
        {
            var userId = await _userService.GetUserInfo();

            createAddressDto.UserID = userId.Id;

            await _addressService.CreateAddress(createAddressDto);
            return RedirectToAction("Index", "Payment");
        }
    }
}
