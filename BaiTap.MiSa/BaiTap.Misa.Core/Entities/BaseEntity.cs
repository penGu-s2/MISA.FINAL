using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Misa.Core.Entities
{/// <summary>
 /// Thuộc tính khóa đối tượng
 /// </summary>
 /// CreatedBy : NguyenThang(1/9)
    [AttributeUsage(AttributeTargets.Property)]
    public class Key : Attribute
    {

    }


    /// <summary>
    /// Cờ Required yêu cầu không để trống
    /// </summary>
    /// CreatedBy : NguyenThang(1/9)
    [AttributeUsage(AttributeTargets.Property)]
    public class Required : Attribute
    {

    }

    /// <summary>
    /// Cờ Duplication thông báo thông tin không được trùng
    /// </summary>
    /// CreatedBy : NguyenThang(1/9)
    [AttributeUsage(AttributeTargets.Property)]
    public class Duplication : Attribute
    {

    }

    /// <summary>
    /// Cờ LengthAndFormat yêu cầu thông tin phải đúng độ dài và định dạng
    /// </summary>
    /// CreatedBy : NguyenThang(1/9)
    [AttributeUsage(AttributeTargets.Property)]

    public class LengthAndFormat : Attribute
    {
        #region Property
        /// <summary>
        /// Yêu cầu độ dài
        /// </summary>
        /// CreatedBy : NguyenThang(1/9)
        public int ValidLength { get; set; }

        /// <summary>
        /// Thông báo lỗi
        /// </summary>
        /// CreatedBy : NguyenThang(1/9)
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Yêu cầu đúng định dạng
        /// </summary>
        /// CreatedBy : NguyenThang(1/9)
        public string Required { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Khởi tạo check độ dài và định dạng 
        /// </summary>
        /// <param name="validLength">Độ dài giá trị</param>
        /// <param name="errorMsg">Thông báo lỗi</param>
        /// <param name="required">Trường yêu cầu</param>
        public LengthAndFormat(int validLength, string errorMsg, string required)
        {
            this.ValidLength = validLength;
            this.ErrorMsg = errorMsg;
            this.Required = required;
        }
        #endregion
    }

    /// <summary>
    /// Cờ Email yêu cầu thông tin email ohair đúng đinh dạng
    /// </summary>
    /// CreatedBy : NguyenThang(1/9)
    public class Email : Attribute
    {

    }

    /// <summary>
    /// Không map csdl
    /// </summary>
    /// CreatedBy : NguyenThang(1/9)
    [AttributeUsage(AttributeTargets.Property)]
    public class NotMapped : Attribute
    {

    }

    /// <summary>
    /// Mapping các bảng
    /// </summary>
    /// CreatedBy : NguyenThang(27/8)
    [AttributeUsage(AttributeTargets.Property)]
    public class Mapping : Attribute { }

    /// <summary>
    /// Các properties chung
    /// </summary>
    /// CreatedBy : NguyenThang(1/9)
    public class BaseEntity
    {
        /// <summary>
        /// Ngày thành lập
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người sáng lập
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày chỉnh sửa
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Người chỉnh sửa
        /// </summary>
        public string ModifiedBy { get; set; }
    }
}
