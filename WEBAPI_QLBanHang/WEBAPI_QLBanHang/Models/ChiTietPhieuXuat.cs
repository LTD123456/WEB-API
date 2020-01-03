using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class ChiTietPhieuXuat : Entity<int>
    {
        //  [Key]
        //public int Id { get; set; }
        public int SanPhamId { get; set; }
        public SanPham SanPham { get; set; }
        public int PhieuXuatId { get; set; }
        public PhieuXuat PhieuXuat { get; set; }
        public double giaTien { get; set; }

    }
}
