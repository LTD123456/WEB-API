using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_QLBanHang.DBContext;

namespace WEBAPI_QLBanHang.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public AppDBContext context { get; }

        public UnitOfWork(AppDBContext cntext)
        {
            this.context = cntext;
        }
        public void Dispose()
        {
            this.context.Dispose();
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
        
    }
}
