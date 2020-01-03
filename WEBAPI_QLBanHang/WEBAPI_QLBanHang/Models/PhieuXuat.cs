﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class PhieuXuat:Entity<int>
    {
        public DateTime? NgayXuat { get; set; }
        public double TongTien { get; set; }
        public int NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
        public ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
    }
}