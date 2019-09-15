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
        readonly IEmployeeRepository EmployeeRepo;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            EmployeeRepo = employeeRepository;
        }

        public List<Employee> GetEmployee(long id)
        {
            var employees = EmployeeRepo.GetEmployees().Result;
            return employees.ConvertAll(new Converter<EmployeeData, Employee>(EmployeeConverter)).Where(t => t.Id == id).Select(t=>t).ToList();
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
