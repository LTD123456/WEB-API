using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class AuditTable : Entity<int>, IAuditTable
    {
        public DateTime CreateTime { get ; set; }
        public DateTime UpdateTime { get; set; }
    }
}
