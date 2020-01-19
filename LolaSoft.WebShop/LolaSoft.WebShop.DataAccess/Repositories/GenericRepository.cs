using LolaSoft.WebShop.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LolaSoft.WebShop.DataAccess.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        T Get(int id);
        void Delete(T entity);
        List<T> GetAll();
    }
    public class GenericRepository<T> where T : class, IModel 
    {
        protected readonly WebShopDbContext context;
        protected readonly DbSet<T> dbSet = null;

        public GenericRepository(WebShopDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            context.Add<T>(entity);
        }

        public void Update(T entity)
        {

            context.Update<T>(entity);
        }

        public T Get(int id)
        {
            return context.Find<T>(id);
        }

        public void Delete(T entity)
        {
            context.Remove<T>(entity);
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }
    }
}