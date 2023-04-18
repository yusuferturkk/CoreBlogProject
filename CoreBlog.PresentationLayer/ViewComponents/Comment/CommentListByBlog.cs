using CoreBlog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.PresentationLayer.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {

        private readonly ICommentService _commentService;

        public CommentListByBlog(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _commentService.GetListCommentById(id);
            return View(value);
        }
    }
}
