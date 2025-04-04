using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W12D3_Person2
{
    public class Person2
    {
        // backing store
        private string _sin;
        private string _firstName;
        private string _lastName;
        private string _address;

        //  socal insurance number
        //  read only (write the value once using the private set) 
        public string SIN
        {
            get
            {
                return _sin;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("SIN cannot be empty");
                }
                _sin = value;
            }
        }
        //  first name
        public string FirstName { get; set; }
        //  last name
        public string LastName { get; set; }

        //  address
        //  read only based on that we are only using the getter
        public string Address
        {
            get
            {
                return _address;
            }
        }

        // greed constructor
        public Person2(string sin, string firstName, string lastName, string address)
        {
            SIN = sin;
            FirstName = firstName;
            LastName = lastName;
            _address = address;
        }

        //  default constructor
        public Person2()
        {

        }

        //  display person information
        public void DisplayPerson()
        {
            Console.WriteLine($"SIN: {SIN}, First Name: {FirstName}, Last Name: {LastName}, Address: {Address}");
        }

    }
}
