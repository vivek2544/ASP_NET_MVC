using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public async Task<List<EmployeeData>> GetEmployees()
        {
            List<EmployeeData> employees = null;
            try
            {
                HttpResponseMessage response = Get("Employees");
                if (response.IsSuccessStatusCode)
                {
                    employees = JsonConvert.DeserializeObject<List<EmployeeData>>(await response.Content.ReadAsStringAsync());
                }
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(string.Format("Error occured while fetching employee data. Message: {0}. {1}Stack: {2}",
                    exception.Message, Environment.NewLine, exception.StackTrace));
            }
            return employees;
        }
    }
}
