using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    interface IEntity<T>
    {
        T Id { get; set; }
    }
}
