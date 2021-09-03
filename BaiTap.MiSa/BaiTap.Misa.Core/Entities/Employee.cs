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
        ///<summary>
        ///Khoá chính
        ///</summary>
        [Key]
        public Guid EmployeeID { get; set; }

        ///<summary>
        ///Mã nhân viên
        /// </summary>
        [Duplication]
        [Required]
        public string EmployeeCode { get; set; }

        ///<summary>
        ///Tên
        /// </summary>
        [Required]
        public string FullName { get; set; }

        ///<summary>
        ///Giới tính
        /// </summary>
        public int? Gender { get; set; }

        ///<summary>
        ///Địa chỉ
        /// </summary>
        public string Address { get; set; }

        ///<summary>
        ///Ngày sinh
        /// </summary>
        public DateTime? DOB { get; set; }

        ///<summary>
        ///Số CMND
        /// </summary>
        public string IdentityNumber { get; set; }

        ///<summary>
        ///Nơi cấp
        /// </summary>
        public string IdentityPlace { get; set; }

        ///<summary>
        ///Ngày cấp
        /// </summary>
        public DateTime? IdentityDate { get; set; }

        ///<summary>
        ///Email
        /// </summary>
        public string Email { get; set; }

        ///<summary>
        ///Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }

        ///<summary>
        ///Số điện thoại cố định
        /// </summary>
        public string StaticPhone { get; set; }

        ///<summary>
        ///Tài khoản ngân hàng
        /// </summary>
        public string AccountNumber { get; set; }

        ///<summary>
        ///Tên ngân hàng
        /// </summary>
        public string BankName { get; set; }

        ///<summary>
        ///Chi nhánh
        /// </summary>
        public string Branch{ get; set; }

        /// <summary>
        /// Chức danh
        /// </summary>
        public string PositionName { get; set; }

        ///<summary>
        ///Khoá ngoại
        ///</summary>
        [Required]
        [Mapping]
        public Guid? DepartmentID { get; set; }


        [NotMapped]
        public string DepartmentName { get; set; }

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
        #endregion

    }
}
