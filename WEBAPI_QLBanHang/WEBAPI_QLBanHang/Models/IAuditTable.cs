using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    interface IAuditTable
    {
        DateTime CreateTime { get; set; }
        DateTime UpdateTime { get; set; }
    }
}
