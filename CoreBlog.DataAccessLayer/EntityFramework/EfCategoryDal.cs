using CoreBlog.DataAccessLayer.Abstract;
using CoreBlog.DataAccessLayer.Concrete;
using CoreBlog.DataAccessLayer.Repositories;
using CoreBlog.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
