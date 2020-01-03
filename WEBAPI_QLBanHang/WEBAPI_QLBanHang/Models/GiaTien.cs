using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class GiaTien:Entity<int>
    {
        [Required]
        public int SanPhamId { get; set; }
        // public virtual SanPham SanPham { get; set; }
        public DateTime NgayCapNhap { get; set; }
        public double giaTien;
    }
}
