using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.ProductDtos;
using MultiShop.DtoLayer.CommentDtos.UserCommentDtos;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;
using MultiShop.WebUI.Services.CommentServices;

namespace MultiShop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;

        public ProductController(IProductService productService, ICommentService commentService)
        {
            _productService = productService;
            _commentService = commentService;
        }

        public IActionResult Index(string id)
        {
            ViewBag.CategoryID = id;
            return View();
        }

        public async Task<IActionResult> Detail(string id)
        {
            ViewBag.ProductID = id;
            var values = await _productService.GetByIdProduct(id);

            var resultProductDto = new ResultProductDto()
            {
                CategoryID = values.CategoryID,
                ProductID = values.ProductID,
                ProductDescription = values.ProductDescription,
                ProductDetail = values.ProductDetail,
                ProductImage1 = values.ProductImage1,
                ProductImage2 = values.ProductImage2,
                ProductImage3 = values.ProductImage3,
                ProductInfo = values.ProductInfo,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice
            };

            return View(resultProductDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(string id, CreateUserCommentDto createUserCommentDto)
        {
            createUserCommentDto.ProductID = id;
            createUserCommentDto.CreatedDate = DateTime.Now;
            createUserCommentDto.Status = false;

            await _commentService.CreateComment(createUserCommentDto);
            return RedirectToAction("Detail", new { id = id });
        }


    }
}
