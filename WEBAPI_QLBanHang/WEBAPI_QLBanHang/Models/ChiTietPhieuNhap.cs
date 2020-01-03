using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class ChiTietPhieuNhap
    {
        [Key]
        public int Id { get; set; }
        public int SanPhamId { get; set; }
        public SanPham SanPham { get; set; }

        public int PhieuNhapId { get; set; }
        //     public  PhieuNhap PhieuNhap { get; set; }
        public double giaTien { get; set; }
    }
}
