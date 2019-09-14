using EmployeeManagement.Data;

namespace EmployeeManagement.Business.Models
{
    public abstract class Employee
    {
        protected Employee(EmployeeData employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            ContractTypeName = employee.ContractTypeName;
            RoleId = employee.RoleId;
            RoleName = employee.RoleName;
            RoleDescription = employee.RoleDescription;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public long RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal AnualSalary { get; set; }
        public abstract void CalculateAnualSalary();
    }

    public class HourlySalaryEmployee : Employee
    {
        public decimal HourlySalary { get; set; }
        public HourlySalaryEmployee(EmployeeData employee) : base(employee)
        {
            HourlySalary = employee.HourlySalary;
        }

        public override void CalculateAnualSalary()
        {
            AnualSalary = 120 * 12 * HourlySalary;
        }
    }

    public class MonthlySalaryEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }
        public MonthlySalaryEmployee(EmployeeData employee) : base(employee)
        {
            MonthlySalary = employee.MonthlySalary;
        }

        public override void CalculateAnualSalary()
        {
            AnualSalary = 12 * MonthlySalary;
        }
    }
}
