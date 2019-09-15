using EmployeeManagement.Business;
using EmployeeManagement.Business.Interfaces;
using EmployeeManagement.Data;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace EmployeeManagement
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}