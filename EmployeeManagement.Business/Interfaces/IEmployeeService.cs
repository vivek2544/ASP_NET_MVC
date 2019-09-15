using EmployeeManagement.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Business.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployee(long id);
        List<Employee> GetEmployees();
    }
}
