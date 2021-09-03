using BaiTap.Misa.Core.Entities;
using BaiTap.Misa.Core.Interfaces.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap.Misa.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController<Employee>
    {
        #region Declare
        private readonly IEmployeeService _employeeService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private const string _nameExcelFile = "Danh_sach_nhan_vien.xlsx";
        private const string _nameSheet = "DANH SÁCH NHÂN VIÊN";
        #endregion
        #region Constructor
        public EmployeesController(IBaseService<Employee> baseService, IEmployeeService employeeService, IHostingEnvironment hostingEnvironment) : base(baseService)
        {
            this._employeeService = employeeService;
            this._hostingEnvironment = hostingEnvironment;
        }
        #endregion

        #region Method
        /// <summary>
        /// Sinh mã nhân viên mới
        /// </summary>
        /// <returns>Dịch vụ sinh mã nhân viên mới</returns>
       
        [HttpGet("NewEmployeeCode")]
        public IActionResult GetNewCode()
        {
            return Ok(_employeeService.GetNewEmployeeCode());
        }

        /// <summary>
        /// Phân trang tìm kiếm nhân viên
        /// </summary>
        /// <param name="keyword">Tìm kiếm theo tên , mã, số điện thoại</param>
        /// <param name="pageIndex">Trang thứ ?</param>
        /// <param name="pageSize">Số lượng lớn nhất bản ghi trên một trang</param>
        /// <returns>Dịch vụ phân trang tìm kiếm nhân ven</returns>
       
        [HttpGet("Paging")]
        public IActionResult GetEemployeesPaging(string keyword, int pageIndex, int pageSize)
        {
            var serviceResult = _employeeService.GetEmployeesPaging(keyword, pageIndex, pageSize);
            return Ok(serviceResult);
        }

        /// <summary>
        /// xuất file excel danh sách nhân viên
        /// </summary>
        /// <returns>Dịch vụ xuất file danh sách nhân viên</returns>
        [HttpGet("Export")]
        public IActionResult ExportEmployeeExcelFile()
        {
            string folder = _hostingEnvironment.WebRootPath;
            string urlDownload = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, _nameExcelFile);
            var serviceResult = new ServiceResult();
            try
            {
                // thông tin file excel
                FileInfo file = new FileInfo(Path.Combine(folder, _nameExcelFile));
                if (file.Exists)
                {
                    // xóa file cũ nếu đã tồn tại
                    file.Delete();
                    file = new FileInfo(Path.Combine(folder, _nameExcelFile));
                }
                // thực hiện xuất file
                serviceResult = _employeeService.ExportExcelData(file);
                serviceResult.Data = urlDownload;
                return Ok(serviceResult);
            }
            catch (Exception ex)
            {
                serviceResult.SetInternalServerError(serviceResult);
                serviceResult.DevMessage.Add(ex.Message);
            }
            return Ok(serviceResult);
        }

        [HttpGet("Duplicate")]
        public IActionResult CheckDuplicateProperty(string name, string value, string id)
        {
            var serviceResult = _employeeService.CheckDuplicate(name, value, id);
            return Ok(serviceResult);
        }
        #endregion
    }
}
