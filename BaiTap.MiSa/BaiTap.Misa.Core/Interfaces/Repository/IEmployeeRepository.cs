using BaiTap.Misa.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Misa.Core.Interfaces.Repository
{
    public interface IEmployeeRepository:IBaseRepository<Employee>
    {
        /// <summary>
        /// Phân trang tìm kiếm nhân viên
        /// </summary>
        /// <param name="keyword">Tìm kiếm theo mã nhân viên, số điện thoại, tên</param>
        /// <param name="pageIndex">Thứ tự trang</param>
        /// <param name="pageSize">Độ dài trang</param>
        /// <returns>Dữ liệu phân tran</returns>
        /// CreatedBy : NguyenThang(1/9)
        public PageResult<Employee> GetEmployeesPaging(string keyword, int pageIndex, int pageSize);

        /// <summary>
        /// Lấy mã nhân viên mới
        /// </summary>
        /// <returns>Mã mới</returns>
        public string GetNewEmployeeCode();
    }
}
