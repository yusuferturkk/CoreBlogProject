using CoreBlog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBlog.PresentationLayer.ViewComponents.Category
{
    public class CategoryListInSidebar : ViewComponent
    {

        private readonly ICategoryService _categoryService;

        public CategoryListInSidebar(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.GetList();
            return View(values);
        }
    }
}
