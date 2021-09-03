using BaiTap.Misa.Core.Entities;
using BaiTap.Misa.Core.Interfaces.Repository;
using BaiTap.Misa.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Misa.Core.Services
{
    public class DepartmentService : BaseService<Department>, IDepartmentService
    {
        #region Declare
        private readonly IDepartmentRepository _departmentRepository;
        #endregion

        #region Constructor
        public DepartmentService(IBaseRepository<Department> baseRepository, IDepartmentRepository departmentRepository) : base(baseRepository)
        {
            this._departmentRepository = departmentRepository;
        }
        #endregion
    }
}
