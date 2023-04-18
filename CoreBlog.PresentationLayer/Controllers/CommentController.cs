using CoreBlog.BusinessLayer.Abstract;
using CoreBlog.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

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

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogId = 2;
            _commentService.Add(comment);
            return PartialView();
        }
    }
}
