using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_QLBanHang.Models;

namespace WEBAPI_QLBanHang.DBContext
{
    public class AppDBContext:DbContext
    {
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { set; get; }
        public DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { set; get; }
        public DbSet<GiaTien> GiaTiens { set; get; }
        public DbSet<NhanVien> NhanViens { set; get; }
        public DbSet<PhieuNhap> PhieuNhaps { set; get; }
        public DbSet<PhieuXuat> PhieuXuats { set; get; }
        public DbSet<SanPham> SanPhams { set; get; }
        public AppDBContext(DbContextOptions<AppDBContext> options)
         : base(options)
        {
            
        }
    }
}
