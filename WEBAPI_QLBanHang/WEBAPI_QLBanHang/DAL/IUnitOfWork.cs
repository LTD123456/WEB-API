using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_QLBanHang.DBContext;

namespace WEBAPI_QLBanHang.DAL
{
    public interface IUnitOfWork:IDisposable
    {
        AppDBContext context { get; } 
        void SaveChanges();
    }
}
