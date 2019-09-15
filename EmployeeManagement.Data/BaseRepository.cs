using System;
using System.Configuration;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace EmployeeManagement.Data
{
    public abstract class BaseRepository
    {
        readonly protected JavaScriptSerializer serializer;
        readonly private HttpClient client;
        public BaseRepository()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["DataRepository"]);
            serializer = new JavaScriptSerializer();
        }

        public HttpResponseMessage Get(string relativePath)
        {
            return client.GetAsync(relativePath).Result;
        }
    }
}