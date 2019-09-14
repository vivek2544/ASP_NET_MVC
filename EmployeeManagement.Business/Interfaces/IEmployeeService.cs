using EmployeeManagement.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Business.Interfaces
{
    interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }
}
