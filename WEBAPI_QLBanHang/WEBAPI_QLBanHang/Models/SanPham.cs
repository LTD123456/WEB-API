using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class SanPham : Entity<Guid>
    {
        [Required]
        public string TenSanPham { get; set; }
        [Required]
        public double GiaSanPham { get; set; }
        [Required]
        public int SoLuongSanPham { get; set; }
        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public ICollection<GiaTien> GiaTiens { get; set; }
    }
}
