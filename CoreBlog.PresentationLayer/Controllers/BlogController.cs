using CoreBlog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.PresentationLayer.Controllers
{
	public class BlogController : Controller
	{

		private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
		{
			var values = _blogService.GetBlogListWithCategory();
			return View(values);
		}

		public IActionResult BlogDetails(int id)
		{
			var value = _blogService.GetBlogById(id);
			return View(value);
		}
	}
}
