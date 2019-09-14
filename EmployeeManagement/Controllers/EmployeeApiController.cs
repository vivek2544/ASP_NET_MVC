using EmployeeManagement.Business;
using EmployeeManagement.Business.Models;
using EmployeeManagement.Filters;
using System.Collections.Generic;
using System.Web.Http;

namespace EmployeeManagement.Controllers
{
    [RoutePrefix("api")]
    public class EmployeeApiController : ApiController
    {
        EmployeeService employeeService = new EmployeeService();
        // GET api/employee
        [HttpGet]
        [Route("{employees}")]
        [CacheControl]
        public List<Employee> Get()
        {
            return employeeService.GetEmployees();
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("{employees}/{id}")]
        public Employee Get(long id)
        {
             return employeeService.GetEmployee(id);
        }
    }
}