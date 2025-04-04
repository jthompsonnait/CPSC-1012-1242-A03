using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W12D2_Person
{
    public class Person
    {
        private string _firstName; // Backing store for FirstName
        private string _lastName; // Backing store for LastName
        private int _age; // Backing store for Age

        // first name
        public string FirstName
        {
            get
            {
                // JAMES
                return  _firstName.ToUpper();
            }
            set
            {
                //  ensure that first name is not empty
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty");
                }
                // James
                _firstName = value;
            }
        }
        // last name
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty");
                }
                _lastName = value;
            }
        }
        //  age
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Age cannot be a negative value: {value}");
                }
                _age = value;
            }
        }
        // constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName =firstName;
            LastName= lastName;
            Age = age;
        }

   
        //  display information about the person
        public void DisplayPerson()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Age:{Age}");
        }
    }
}
