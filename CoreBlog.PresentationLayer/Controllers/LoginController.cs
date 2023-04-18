using CoreBlog.BusinessLayer.Abstract;
using CoreBlog.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBlog.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {

        private readonly IWriterService _writerService;

        public LoginController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            return View();
        }
    }
}
