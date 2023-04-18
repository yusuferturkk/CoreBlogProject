using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.PresentationLayer.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page404(int code)
        {
            return View();
        }
    }
}
