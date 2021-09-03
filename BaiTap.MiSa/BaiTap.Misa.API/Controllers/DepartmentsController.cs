using BaiTap.Misa.Core.Entities;
using BaiTap.Misa.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap.Misa.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DepartmentsController : BaseController<Department>
    {
        #region Declare
        private readonly IDepartmentService _departmentService;
        #endregion

        #region Constructor
        public DepartmentsController(IBaseService<Department> baseService, IDepartmentService departmentService) : base(baseService)
        {
            this._departmentService = departmentService;
        }
        #endregion
    }
}
