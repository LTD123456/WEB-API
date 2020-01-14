using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI_QLBanHang.DTO.DTOInterface;
using WEBAPI_QLBanHang.Models;

namespace WEBAPI_QLBanHang.Controllers
{
    [Route("api/NhanVien")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        INhanVien _INhanVien;
        public NhanVienController(INhanVien nv)
        {
            _INhanVien = nv;
        }

        [Route("Get")]
        [HttpGet]
        public ActionResult GetNV()
        {
            //_ICourseServer.Add(Course);
            //_INhanVien.Add(nv);
            var listNV = _INhanVien.getAll<NhanVien>().ToList();
            return Ok(listNV);
        }

        [Route("Add")]
        [HttpPost]
        public ActionResult AddNV(NhanVien nv)
        {
            //_ICourseServer.Add(Course);
            _INhanVien.Add(nv);
            return Ok(true);
        }
    }
}