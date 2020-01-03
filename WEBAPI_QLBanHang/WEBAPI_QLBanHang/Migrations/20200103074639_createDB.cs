using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBAPI_QLBanHang.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HoTenNV = table.Column<string>(nullable: false),
                    NgayThamGia = table.Column<DateTime>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CapBac = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    TongTien = table.Column<double>(nullable: false),
                    NhanVienId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TenSanPham = table.Column<string>(nullable: false),
                    GiaSanPham = table.Column<double>(nullable: false),
                    SoLuongSanPham = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhieuXuats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayXuat = table.Column<DateTime>(nullable: true),
                    TongTien = table.Column<double>(nullable: false),
                    NhanVienId = table.Column<int>(nullable: false),
                    NhanVienId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuXuats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuXuats_NhanViens_NhanVienId1",
                        column: x => x.NhanVienId1,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuNhaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SanPhamId = table.Column<int>(nullable: false),
                    SanPhamId1 = table.Column<Guid>(nullable: true),
                    PhieuNhapId = table.Column<int>(nullable: false),
                    giaTien = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuNhaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhaps_PhieuNhaps_PhieuNhapId",
                        column: x => x.PhieuNhapId,
                        principalTable: "PhieuNhaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhaps_SanPhams_SanPhamId1",
                        column: x => x.SanPhamId1,
                        principalTable: "SanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiaTiens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SanPhamId = table.Column<int>(nullable: false),
                    NgayCapNhap = table.Column<DateTime>(nullable: false),
                    SanPhamId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTiens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaTiens_SanPhams_SanPhamId1",
                        column: x => x.SanPhamId1,
                        principalTable: "SanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuXuats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SanPhamId = table.Column<int>(nullable: false),
                    SanPhamId1 = table.Column<Guid>(nullable: true),
                    PhieuXuatId = table.Column<int>(nullable: false),
                    giaTien = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuXuats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuats_PhieuXuats_PhieuXuatId",
                        column: x => x.PhieuXuatId,
                        principalTable: "PhieuXuats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuats_SanPhams_SanPhamId1",
                        column: x => x.SanPhamId1,
                        principalTable: "SanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhaps_PhieuNhapId",
                table: "ChiTietPhieuNhaps",
                column: "PhieuNhapId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhaps_SanPhamId1",
                table: "ChiTietPhieuNhaps",
                column: "SanPhamId1");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuXuats_PhieuXuatId",
                table: "ChiTietPhieuXuats",
                column: "PhieuXuatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuXuats_SanPhamId1",
                table: "ChiTietPhieuXuats",
                column: "SanPhamId1");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTiens_SanPhamId1",
                table: "GiaTiens",
                column: "SanPhamId1");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuats_NhanVienId1",
                table: "PhieuXuats",
                column: "NhanVienId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuNhaps");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuXuats");

            migrationBuilder.DropTable(
                name: "GiaTiens");

            migrationBuilder.DropTable(
                name: "PhieuNhaps");

            migrationBuilder.DropTable(
                name: "PhieuXuats");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "NhanViens");
        }
    }
}
