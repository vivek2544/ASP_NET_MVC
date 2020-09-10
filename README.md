# ASP.NET MVC DEMO
Employee Management Project

**Project Structure:**
 - EmployeeManagement.Web [ASP.NET MVC Project] - UI Layer
 - EmployeeManagement.Business [.NET Standard Library] - Business layer
 - EmployeeManagement.Data [.NET Standard Library] - Data layer
 - EmployeeManagement.Business.Tests [Test cases for Business layer]

**Features Of EmployeeManagement.Web:**

    This project is developed using ASP.NET MVC. It consist of API Controller, uses Business service through Dependancy injection. Also API Controller method is decorated Cache Control Action filter which caches the api endpoint result for 10 seconds.


**Features Of EmployeeManagement.Business:**

    This project is developed as a.NET Standard class library. .**NET Standard will** run on any .**NET Standard** compliant runtime, such as .**NET Core**, .**NET** Framework, Mono/Xamarin. 
    Also I have implemented Factory Method pattern to generate concret DTO object. 
