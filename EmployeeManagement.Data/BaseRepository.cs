using System;
using System.Configuration;
using System.Net.Http;

namespace EmployeeManagement.Data
{
    public abstract class BaseRepository
    {
        readonly private HttpClient client;
        protected BaseRepository()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["DataRepository"]);
        }

        public HttpResponseMessage Get(string relativePath)
        {
            return client.GetAsync(relativePath).Result;
        }
    }
}