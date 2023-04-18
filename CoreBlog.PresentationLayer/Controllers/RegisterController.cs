using CoreBlog.BusinessLayer.Abstract;
using CoreBlog.BusinessLayer.ValidationRules;
using CoreBlog.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.PresentationLayer.Controllers
{
	public class RegisterController : Controller
	{

		private readonly IWriterService _writerService;

		public RegisterController(IWriterService writerService)
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
			WriterValidator validator = new WriterValidator();
			ValidationResult results = validator.Validate(writer);

			if (results.IsValid & writer.WriterPassword == writer.ConfirmPassword)
			{
				writer.WriterStatus = true;
				_writerService.Add(writer);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
