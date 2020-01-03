using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_QLBanHang.DBContext;

namespace WEBAPI_QLBanHang.DAL
{
    public class Repository : IRepository
    {
        private readonly AppDBContext context;
        public Repository(AppDBContext cntext)
        {
            this.context = cntext;
        }

        public void Add<T>(T entity) where T : class
        {
            this.context.Set<T>().Add(entity);
        }

        public void AddOrUpdate<T>(T entity) where T : class
        {
            var exist = this.context.Set<T>().Find(entity) !=null;
            if(exist)
            {
                this.context.Set<T>().Add(entity);
            }
            else
            {
                this.context.Set<T>().Update(entity);
            }
        }

        public void Delete<T>(Guid id) where T : class
        {
            var entity = this.context.Set<T>().Find(id);
            if (entity != null)
                this.context.Set<T>().Remove(entity);
        }

        public List<T> getAll<T>() where T : class
        {
            return this.context.Set<T>().ToList();
        }

        public T getByID<T>(Guid id) where T : class
        {
            var objectEntity = this.context.Set<T>().Find(id);
            return objectEntity;
        }

        public void Update<T>(T entity) where T : class
        {
            if(entity != null)
            {
                this.context.Set<T>().Update(entity);
            }
        }
    }
}
