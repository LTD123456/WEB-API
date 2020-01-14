using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_QLBanHang.Models;

namespace WEBAPI_QLBanHang.DTO.DTOInterface
{
    public interface INhanVien
    {
        List<WEBAPI_QLBanHang.Models.NhanVien> getAll<NhanVien>();
        NhanVien getByID(Guid id);
        void Add(NhanVien nv);
        void Delete(Guid id);
        void Update<T>(T entity);
        void AddOrUpdate<T>(T entity);
    }
}
