using EmployeeManagement.Business.Models;
using EmployeeManagement.Data;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace EmployeeManagement.Business.Tests
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        Mock<IEmployeeRepository> mock;
        public EmployeeServiceTests()
        {
            mock = new Mock<IEmployeeRepository>();
        }
        
        [SetUp]
        public void Setup()
        {
            ConfigurationManager.AppSettings["DataRepository"] = "http://masglobaltestapi.azurewebsites.net/api/";
            List<EmployeeData> employeeMockData = new List<EmployeeData>();
            employeeMockData.Add(new EmployeeData()
            {
                Id = 1,
                ContractTypeName = "HourlySalaryEmployee",
                HourlySalary = 60000,
                MonthlySalary = 80000,
                Name = "Juan",
                RoleDescription = "",
                RoleId = 1,
                RoleName = "Administrator"
            });
            employeeMockData.Add(new EmployeeData()
            {
                Id = 2,
                ContractTypeName = "MonthlySalaryEmployee",
                HourlySalary = 60000,
                MonthlySalary = 80000,
                Name = "Sebastian",
                RoleDescription = "",
                RoleId = 2,
                RoleName = "Contractor"
            });
            mock.Setup(p => p.GetEmployees()).Returns(Task.FromResult(employeeMockData));
        }

        [Test]
        public void GetEmployee_HourlySalaryEmployees()
        {            
            var employees = new EmployeeService(mock.Object).GetEmployee(1);
            Assert.True(employees[0].GetType() == typeof(HourlySalaryEmployee));
            Assert.True(employees[0].GetType() != typeof(MonthlySalaryEmployee));
            Assert.True(employees.Count == 1);
        }

        [Test]
        public void GetEmployee_MonthlySalaryEmployee()
        {
            var employees = new EmployeeService(mock.Object).GetEmployee(2);
            Assert.True(employees[0].GetType() != typeof(HourlySalaryEmployee));
            Assert.True(employees[0].GetType() == typeof(MonthlySalaryEmployee));
            Assert.True(employees.Count == 1);
        }

        [Test]
        public void GetEmployees_AllRecords()
        {
            var allEmployees = new EmployeeService(mock.Object).GetEmployees();
            Assert.True(allEmployees.Count == 2);
        }

        [Test]
        public void GetEmployee_OneRecord()
        {
            var employees = new EmployeeService(mock.Object).GetEmployee(1);
            Assert.True(employees.Count == 1);
        }

        [Test]
        public void GetEmployee_NoRecord()
        {
            var employees = new EmployeeService(mock.Object).GetEmployee(123);
            Assert.True(employees.Count == 0);
        }
    }
}