using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.Business.Factory;
using EmployeeManagement.Business.Interfaces;
using EmployeeManagement.Business.Models;
using EmployeeManagement.Data;

namespace EmployeeManagement.Business
{
    public class EmployeeService : IEmployeeService
    {
        readonly EmployeeRepository EmployeeRepo = new EmployeeRepository();
        public Employee GetEmployee(long id)
        {
            var employees = EmployeeRepo.GetEmployees().Result;
            return employees.ConvertAll(new Converter<EmployeeData, Employee>(EmployeeConverter)).FirstOrDefault(t => t.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            var employees = EmployeeRepo.GetEmployees().Result;
            return employees.ConvertAll(new Converter<EmployeeData, Employee>(EmployeeConverter));
        }
        public static Employee EmployeeConverter(EmployeeData employeeData)
        {
            return FactoryService.CreateEmployee(employeeData);
        }
    }
}
