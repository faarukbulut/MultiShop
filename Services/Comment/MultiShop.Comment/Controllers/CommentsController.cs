using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Comment.Context;
using MultiShop.Comment.Entities;

namespace MultiShop.Comment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly CommentContext _context;

        public CommentsController(CommentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _context.UserComments.ToList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var value = _context.UserComments.Find(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateComment(UserComment userComment)
        {
            _context.UserComments.Add(userComment);
            _context.SaveChanges();
            return Ok("Ekleme Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateComment(UserComment userComment)
        {
            _context.UserComments.Update(userComment);
            _context.SaveChanges();
            return Ok("Düzenleme Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteComment(int id)
        {
            var value = _context.UserComments.Find(id);
            _context.UserComments.Remove(value);
            _context.SaveChanges();
            return Ok("Silme Başarılı");
        }

        [HttpGet("CommentListByProductId")]
        public IActionResult CommentListByProductId(string id)
        {
            var value = _context.UserComments.Where(x => x.ProductID == id).ToList();
            return Ok(value);
        }

    }
}
