using System;
namespace DAL
{
    public interface IEmployeeProvider
    {
        System.Collections.Generic.List<Model.Person> GetEmployees();
    }
}
