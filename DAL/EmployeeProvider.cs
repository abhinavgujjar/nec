using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeProvider : DAL.IEmployeeProvider
    {
        public List<Person> GetEmployees()
        {
            var emps = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Steve Jobs",
                    Income = 80000
                },
                 new Person()
                {
                    FirstName = "Bill Gates",
                    Income = 234000
                },
                 new Person()
                {
                    FirstName = "Mark Zuckerberg",
                    Income = 2320000
                },
                 new Person()
                {
                    FirstName = "Chris Evans",
                    Income = 232000
                },
                 new Person()
                {
                    FirstName = "Chris Evans",
                    Income = 232000
                }
            };

            return emps;

        }
    }
}
