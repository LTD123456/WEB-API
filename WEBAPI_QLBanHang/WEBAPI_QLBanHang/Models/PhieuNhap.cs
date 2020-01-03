using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class PhieuNhap:AuditTable
    {
        public double TongTien { get; set; }
        public int NhanVienId { get; set; }
        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
    }
}
