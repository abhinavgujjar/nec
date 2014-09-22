using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public double Income { get; set; }

        public Person(DateTime dob)
        {
            if (dob > DateTime.Now)
            {
                throw new ArgumentException();
            }

            DateOfBirth = dob;
        }

        public Person()
        {
            // TODO: Complete member initialization
        }

        public int Age
        {
            get
            {
                //calculate the age
                return (DateTime.Now.Year - DateOfBirth.Year);
            }
        }
    }
}
