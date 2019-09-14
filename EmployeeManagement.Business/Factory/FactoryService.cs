using EmployeeManagement.Business.Models;
using EmployeeManagement.Data;

namespace EmployeeManagement.Business.Factory
{
    public static class FactoryService
    {
        public static Employee CreateEmployee(EmployeeData employeeData)
        {
            Employee employee = null;
            switch (employeeData.ContractTypeName)
            {
                case "HourlySalaryEmployee":
                    employee = new HourlySalaryEmployee(employeeData);
                    break;
                case "MonthlySalaryEmployee":
                    employee = new MonthlySalaryEmployee(employeeData);
                    break;
                default:
                    break;
            }
            if (employee != null)
            {
                employee.CalculateAnualSalary();
            }
            return employee;
        }

    }
}
