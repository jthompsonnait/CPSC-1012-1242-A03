using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W12D3_WorkingWithObjects
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //  create a full name from first and last name
        //public string FullName()
        //{
        //    return $"{FirstName} {LastName}";
        //}

        //  create a full name as a property
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        //  greed constructor
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
