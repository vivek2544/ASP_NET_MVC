using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public string Name { get; set; }

        private string contractTypeName;
        public string ContractTypeName
        {
            get { return contractTypeName; }
            set
            {
                if (value == "HourlySalaryEmployee")
                {
                    contractTypeName = "Hourly Salary";
                }
                else if(value == "MonthlySalaryEmployee")
                {
                    contractTypeName = "Monthly Salary";
                }
                else
                {
                    contractTypeName = "Unknown";
                }
            }
        }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal AnualSalary { get; set; }
    }
}