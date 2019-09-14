namespace EmployeeManagement.Data
{
    public class EmployeeData
    {
        private long id { get; set; }
        public long Id { get { return id; } set { id = value; } }

        private string contractTypeName { get; set; }
        public string ContractTypeName { get { return contractTypeName; } set { contractTypeName = value; } }

        private string name { get; set; }
        public string Name { get { return name; } set { name = value; } }

        private long roleId { get; set; }
        public long RoleId { get { return roleId; } set { roleId = value; } }

        private string roleName { get; set; }
        public string RoleName { get { return roleName; } set { roleName = value; } }

        private string roleDescription { get; set; }
        public string RoleDescription { get { return roleDescription; } set { roleDescription = value; } }

        private decimal hourlySalary { get; set; }
        public decimal HourlySalary { get { return hourlySalary; } set { hourlySalary = value; } }

        private decimal monthlySalary { get; set; }
        public decimal MonthlySalary { get { return monthlySalary; } set { monthlySalary = value; } }

    }
}
