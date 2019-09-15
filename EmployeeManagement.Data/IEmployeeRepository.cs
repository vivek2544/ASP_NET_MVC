
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeData>> GetEmployees();
    }
}
