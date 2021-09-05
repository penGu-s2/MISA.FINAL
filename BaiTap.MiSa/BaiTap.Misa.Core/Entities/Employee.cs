using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Misa.Core.Entities
{
    public class Employee:BaseEntity
    {
        #region property
        /// <summary>
        /// Id nhân viên 
        /// </summary>
      
        [Key]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
      
        [Duplication]
        [Required]
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Tên nhân viên
        /// </summary>
      
        [Required]
        public string FullName { get; set; }

        /// <summary>
        /// Ngày sinh 
        /// </summary>
      
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
      
        public int? Gender { get; set; }

        /// <summary>
        /// Đơn vị id
        /// </summary>
        [Required]
        [Mapping]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Số chứng minh thư
        /// </summary>
      
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Ngày cấp
        /// </summary>
      
        public DateTime? IdentityDate { get; set; }

        /// <summary>
        /// Nơi cấp
        /// </summary>
      
        public string IdentityPlace { get; set; }

        /// <summary>
        /// Chức danh
        /// </summary>
      
        public string PositionName { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
      
        public string Address { get; set; }

        /// <summary>
        /// Số điện thoại di động
        /// </summary>
      
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Số điện thoại cố định
        /// </summary>
      
        public string Hotline { get; set; }

        /// <summary>
        /// Email
        /// </summary>
      
        [Email]
        public string Email { get; set; }

        /// <summary>
        /// Tài khoản ngân hàng
        /// </summary>
      
        public string AccountNumber { get; set; }

        /// <summary>
        /// Tên ngân hàng
        /// </summary>
      
        public string BankName { get; set; }

        /// <summary>
        /// Tên chi nhánh
        /// </summary>
      
        public string BranchName { get; set; }


        /// <summary>
        /// Tên đơn vị
        /// </summary>
      
        [NotMapped]
        public string DepartmentName { get; set; }

        /// <summary>
        /// Tên giới tính
        /// </summary>
        [NotMapped]
        public string GenderName
        {
            get
            {
                switch (this.Gender)
                {
                    case 0:
                        return Properties.Resources.Male;
                    case 1:
                        return Properties.Resources.Female;
                    case 2:
                        return Properties.Resources.Other;
                    default:
                        return "";
                }
            }
            set
            {
                this.GenderName = value;
            }
        }

    }
    #endregion

}

