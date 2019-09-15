using System;
using System.Net.Http.Headers;
using System.Web.Http.Filters;

namespace EmployeeManagement.Filters
{
    public class CacheControlAttribute : ActionFilterAttribute
    {
        public int MaxAge { get; set; }

        public CacheControlAttribute()
        {
            MaxAge = 10;
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Response != null)
                actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    Public = true,
                    MaxAge = TimeSpan.FromSeconds(MaxAge)
                };

            base.OnActionExecuted(actionExecutedContext);
        }
    }
}