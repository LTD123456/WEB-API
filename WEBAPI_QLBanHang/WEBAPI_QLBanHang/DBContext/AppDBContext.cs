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
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ChiTietPhieuNhap>().
        //}
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhap { set; get; }
        public DbSet<ChiTietPhieuXuat> ChiTietPhieuXuat { set; get; }
        public DbSet<GiaTien> GiaTien { set; get; }
        public DbSet<NhanVien> NhanVien { set; get; }
        public DbSet<PhieuNhap> PhieuNhap { set; get; }
        public DbSet<PhieuXuat> PhieuXuat { set; get; }
        public DbSet<SanPham> SanPham { set; get; }
        public DbSet<UtilsID> UtilsID { set; get; }
        public AppDBContext(DbContextOptions<AppDBContext> options)
         : base(options)
        {
            
        }
    }
}
