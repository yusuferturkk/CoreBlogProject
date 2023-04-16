using CoreBlog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.PresentationLayer.Controllers
{
    public class CommentController : Controller
    {

        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialCommentListByBlog(int id)
        {
            var value = _commentService.GetListCommentById(id);
            return PartialView(value);
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
    }
}
