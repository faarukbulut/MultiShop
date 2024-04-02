using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CommentServices;

namespace MultiShop.WebUI.ViewComponents._ProductDetailPage
{
    public class _ProductDetailPageProductReviewComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _ProductDetailPageProductReviewComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            ViewBag.ProductID = id;
            var values = await _commentService.CommentListByProductId(id);
            return View(values);
        }
    }
}
