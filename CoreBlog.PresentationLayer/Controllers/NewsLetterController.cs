using CoreBlog.BusinessLayer.Abstract;
using CoreBlog.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.PresentationLayer.Controllers
{
    public class NewsLetterController : Controller
    {
        private readonly INewsLetterService _newsLetterService;

        public NewsLetterController(INewsLetterService newsLetterService)
        {
            _newsLetterService = newsLetterService;
        }

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            _newsLetterService.Add(newsLetter);
            return PartialView();
        }
    }
}
