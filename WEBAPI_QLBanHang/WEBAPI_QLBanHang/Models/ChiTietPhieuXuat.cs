using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class ChiTietPhieuXuat : Entity<int>
    {
        [Key]
        [Column(Order = 1)]
        public string SanPhamId { get; set; }
        [Key]
        [Column(Order = 2)]
        public string PhieuXuatId { get; set; }
        public SanPham SanPham { get; set; }
        public PhieuXuat PhieuXuat { get; set; }
        public double giaTien { get; set; }

    }
}
