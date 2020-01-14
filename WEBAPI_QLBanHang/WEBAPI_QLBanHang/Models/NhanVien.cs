using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class NhanVien:Entity<Guid>
    {
        public Guid ID { get; set; }
        [Key]
        public string IDNhanVien { get; set; }
        [Required]
        public string HoTenNV { get; set; }
        public DateTime NgayThamGia { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string CapBac { get; set; }
    }
}
