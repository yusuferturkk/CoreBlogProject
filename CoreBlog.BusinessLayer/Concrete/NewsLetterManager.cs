using CoreBlog.BusinessLayer.Abstract;
using CoreBlog.DataAccessLayer.Abstract;
using CoreBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        private readonly INewsLetterDal _newsLetterDal;
        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void Add(NewsLetter entity)
        {
            _newsLetterDal.Add(entity);
        }

        public void Update(NewsLetter entity)
        {
            _newsLetterDal.Update(entity);
        }

        public void Delete(NewsLetter entity)
        {
            _newsLetterDal.Delete(entity);
        }

        public NewsLetter GetById(int id)
        {
            return _newsLetterDal.GetById(id);
        }

        public List<NewsLetter> GetList()
        {
            return _newsLetterDal.GetList();
        }

        public List<NewsLetter> GetList(Expression<Func<NewsLetter, bool>> filter)
        {
            return _newsLetterDal.GetList(filter);
        }
    }
}
