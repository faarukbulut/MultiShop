using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.ProductDtos;
using MultiShop.DtoLayer.CommentDtos.UserCommentDtos;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index(string id)
        {
            ViewBag.CategoryID = id;
            return View();
        }

        public async Task<IActionResult> Detail(string id)
        {
            ViewBag.ProductID = id;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7070/api/Products/" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultProductDto>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(string id, CreateUserCommentDto createUserCommentDto)
        {
            createUserCommentDto.ProductID = id;
            createUserCommentDto.CreatedDate = DateTime.Now;
            createUserCommentDto.Status = false;

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createUserCommentDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7075/api/Comments", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Detail", new { id = id });
            }

            return View();
        }


    }
}
