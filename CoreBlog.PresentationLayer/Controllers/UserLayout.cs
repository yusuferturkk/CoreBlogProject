using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.PresentationLayer.Controllers
{
    public class UserLayout : Controller
    {
        public IActionResult _UserLayout()
        {
            return View();
        }

		public PartialViewResult PartialHeader()
		{
			return PartialView();
		}

		public PartialViewResult PartialNavbar()
		{
			return PartialView();
		}

		public PartialViewResult PartialFooter()
		{
			return PartialView();
		}

		public PartialViewResult PartialScript()
		{
			return PartialView();
		}
	}
}
