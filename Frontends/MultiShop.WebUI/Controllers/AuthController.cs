using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.DtoLayer.IdentityDtos.RegisterDtos;
using MultiShop.WebUI.Models;
using MultiShop.WebUI.Services.Abstract;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MultiShop.WebUI.Controllers
{
    public class AuthController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly IIdentityService _identityService;

		public AuthController(IHttpClientFactory httpClientFactory, IIdentityService identityService)
		{
			_httpClientFactory = httpClientFactory;
			_identityService = identityService;
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
			if (createRegisterDto.Password == createRegisterDto.ConfirmPassword)
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

		[HttpGet]
		public IActionResult Login()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Login(SignInDto signInDto)
		{
			await _identityService.SignIn(signInDto);
			return RedirectToAction("Index", "Home");

			//var client = _httpClientFactory.CreateClient();
			//var jsonData = JsonConvert.SerializeObject(createLoginDto);
			//StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			//var responseMessage = await client.PostAsync("https://localhost:5001/api/Logins", stringContent);

			//if (responseMessage.IsSuccessStatusCode)
			//{
			//	var responseData = await responseMessage.Content.ReadAsStringAsync();
			//	var tokenModel = JsonConvert.DeserializeObject<JwtResponseModel>(responseData);

			//	if (tokenModel != null)
			//	{
			//		JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
			//		var token = handler.ReadJwtToken(tokenModel.Token);
			//		var claims = token.Claims.ToList();

			//		if(tokenModel.Token != null)
			//		{
			//			claims.Add(new Claim("multishoptoken", tokenModel.Token));
			//			var claimsidentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
			//			var authProps = new AuthenticationProperties
			//			{
			//				ExpiresUtc = tokenModel.ExpireDate,
			//				IsPersistent = false
			//			};

			//			await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsidentity), authProps);
			//			return RedirectToAction("Index", "Home");
			//		}

			//	}

			//	return RedirectToAction("Login");
			//}

			//return RedirectToAction("Login");
		}

	}
}
