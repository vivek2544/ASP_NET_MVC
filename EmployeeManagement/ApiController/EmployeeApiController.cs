using EmployeeManagement.Business.Interfaces;
using EmployeeManagement.Business.Models;
using EmployeeManagement.Filters;
using System.Collections.Generic;
using System.Web.Http;

namespace EmployeeManagement.Controllers
{
    [RoutePrefix("api")]
    public class EmployeeApiController : ApiController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeApiController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("{employees}")]
        [CacheControl]
        public List<Employee> Get(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return _employeeService.GetEmployees();
            }
            else
            {
                long longId = -1;
                long.TryParse(id, out longId);
                return _employeeService.GetEmployee(longId);
            }
        }

    }
}