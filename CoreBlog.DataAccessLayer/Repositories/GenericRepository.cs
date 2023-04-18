using CoreBlog.DataAccessLayer.Abstract;
using CoreBlog.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class
    {

        Context context = new Context();

        public void Add(TEntity entity)
        {
            using (context)
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Update(TEntity entity)
        {
            using (context)
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (context)
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetList()
        {
            return context.Set<TEntity>().ToList();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().Where(filter).ToList();
        }
    }
}
