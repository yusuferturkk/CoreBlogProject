using CoreBlog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.PresentationLayer.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        private readonly IBlogService _blogService;

        public WriterLastBlog(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _blogService.GetBlogListByWriter(2);
            return View(values);
        }
    }
}
