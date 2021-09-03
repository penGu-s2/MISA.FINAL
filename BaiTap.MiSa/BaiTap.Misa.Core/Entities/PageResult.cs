using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Misa.Core.Entities
{
    public class PageResult<T>
    {
        /// <summary>
        /// Thứ tự trạng
        /// </summary>
        /// CreatedBy :NguyeThang(1/9)
        public int PageIndex { get; set; }

        /// <summary>
        /// Độ dài bản ghi trên một trang
        /// </summary>
        /// CreatedBy :NguyeThang(1/9)
        public int PageSize { get; set; }

        /// <summary>
        /// Tổng số bản ghi
        /// </summary>
        /// CreatedBy :NguyeThang(1/9)
        public int TotalRecord { get; set; }

        /// <summary>
        /// Tổng số trang
        /// </summary>
        /// CreatedBy :NguyeThang(1/9)
        public int TotalPage { get; set; }

        /// <summary>
        /// Số bản ghi trên trang hiện tại
        /// </summary>
        /// CreatedBy : LP(27/8)
        public int TotalRecordOnCurrentPage { get; set; }

        /// <summary>
        /// Dữ liệu phân trang
        /// </summary>
        /// CreatedBy :NguyeThang(1/9)
        public IEnumerable<T> Data { get; set; }
    }
}
