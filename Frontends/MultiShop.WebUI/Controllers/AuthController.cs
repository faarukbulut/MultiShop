using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.RegisterDtos;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Controllers
{
    public class AuthController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public AuthController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public IActionResult Login()
        {
            return View();
        }

		[HttpGet]
        public IActionResult Register()
        {
            return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(CreateRegisterDto createRegisterDto)
		{
			if(createRegisterDto.Password == createRegisterDto.ConfirmPassword)
			{
				var client = _httpClientFactory.CreateClient();
				var jsonData = JsonConvert.SerializeObject(createRegisterDto);
				StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
				var responseMessage = await client.PostAsync("https://localhost:5001/api/Registers", stringContent);

				if (responseMessage.IsSuccessStatusCode)
				{
					return RedirectToAction("Login");
				}
			}

			return View();
		}
	}
}
