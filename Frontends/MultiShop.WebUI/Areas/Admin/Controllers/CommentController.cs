using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CommentDtos.UserCommentDtos;
using MultiShop.WebUI.Services.CommentServices;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _commentService.GetAllComment();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateComment(string id)
        {
            var values = await _commentService.GetByIdComment(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateComment(UpdateUserCommentDto updateCommentDto)
        {
            await _commentService.UpdateComment(updateCommentDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteComment(string id)
        {
            await _commentService.DeleteComment(id);
            return RedirectToAction("Index");
        }
    }
}
