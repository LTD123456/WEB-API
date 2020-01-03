using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.DAL
{
    interface IRepository
    {
        List<T> getAll<T>() where T:class;
        T getByID<T>(Guid id) where T : class;
        void Add<T>(T entity) where T : class;
        void Delete<T>(Guid id) where T : class;
        void Update<T>(T entity) where T : class;
        void AddOrUpdate<T>(T entity) where T : class;
    }
}
