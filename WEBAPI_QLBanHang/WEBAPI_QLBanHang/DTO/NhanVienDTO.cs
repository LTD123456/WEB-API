using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_QLBanHang.DAL;
using WEBAPI_QLBanHang.DBContext;
using WEBAPI_QLBanHang.DTO.DTOInterface;
using WEBAPI_QLBanHang.Models;

namespace WEBAPI_QLBanHang.DTO
{
    internal class NhanVienDTO : INhanVien
    {
        private IRepository _IRepository;
        private IUnitOfWork _IUnitOfWork;
        public NhanVienDTO(IUnitOfWork iUnitOfWork, IRepository iRepository)
        {
            _IRepository = iRepository;
            _IUnitOfWork = iUnitOfWork;
        }

        public void Add(NhanVien nv)
        {
            nv.Id = Guid.NewGuid();
            _IRepository.Add<NhanVien>(nv);
            _IUnitOfWork.SaveChanges();

        }

        public void AddOrUpdate<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<WEBAPI_QLBanHang.Models.NhanVien> getAll<NhanVien>()
        {
            var listNV = _IRepository.getAll<WEBAPI_QLBanHang.Models.NhanVien>().ToList();
            return listNV;
        }

        public NhanVien getByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
