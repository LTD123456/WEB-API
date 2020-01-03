﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBAPI_QLBanHang.DBContext;

namespace WEBAPI_QLBanHang.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20200103074639_createDB")]
    partial class createDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.ChiTietPhieuNhap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PhieuNhapId")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamId")
                        .HasColumnType("int");

                    b.Property<Guid?>("SanPhamId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("giaTien")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PhieuNhapId");

                    b.HasIndex("SanPhamId1");

                    b.ToTable("ChiTietPhieuNhaps");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.ChiTietPhieuXuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PhieuXuatId")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamId")
                        .HasColumnType("int");

                    b.Property<Guid?>("SanPhamId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("giaTien")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PhieuXuatId");

                    b.HasIndex("SanPhamId1");

                    b.ToTable("ChiTietPhieuXuats");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.GiaTien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NgayCapNhap")
                        .HasColumnType("datetime2");

                    b.Property<int>("SanPhamId")
                        .HasColumnType("int");

                    b.Property<Guid?>("SanPhamId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SanPhamId1");

                    b.ToTable("GiaTiens");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CapBac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayThamGia")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.PhieuNhap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("NhanVienId")
                        .HasColumnType("int");

                    b.Property<double>("TongTien")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PhieuNhaps");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.PhieuXuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("NgayXuat")
                        .HasColumnType("datetime2");

                    b.Property<int>("NhanVienId")
                        .HasColumnType("int");

                    b.Property<Guid?>("NhanVienId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TongTien")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("NhanVienId1");

                    b.ToTable("PhieuXuats");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("GiaSanPham")
                        .HasColumnType("float");

                    b.Property<int>("SoLuongSanPham")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.ChiTietPhieuNhap", b =>
                {
                    b.HasOne("WEBAPI_QLBanHang.Models.PhieuNhap", null)
                        .WithMany("ChiTietPhieuNhaps")
                        .HasForeignKey("PhieuNhapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEBAPI_QLBanHang.Models.SanPham", "SanPham")
                        .WithMany("ChiTietPhieuNhaps")
                        .HasForeignKey("SanPhamId1");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.ChiTietPhieuXuat", b =>
                {
                    b.HasOne("WEBAPI_QLBanHang.Models.PhieuXuat", "PhieuXuat")
                        .WithMany("ChiTietPhieuXuats")
                        .HasForeignKey("PhieuXuatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEBAPI_QLBanHang.Models.SanPham", "SanPham")
                        .WithMany("ChiTietPhieuXuats")
                        .HasForeignKey("SanPhamId1");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.GiaTien", b =>
                {
                    b.HasOne("WEBAPI_QLBanHang.Models.SanPham", null)
                        .WithMany("GiaTiens")
                        .HasForeignKey("SanPhamId1");
                });

            modelBuilder.Entity("WEBAPI_QLBanHang.Models.PhieuXuat", b =>
                {
                    b.HasOne("WEBAPI_QLBanHang.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("NhanVienId1");
                });
#pragma warning restore 612, 618
        }
    }
}
