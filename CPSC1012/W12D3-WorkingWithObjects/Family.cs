using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W12D3_WorkingWithObjects
{
    public  class Family
    {
        //  create a list of person call Members.  You need to create an instance of the list
        //  of person
        public List<Person> Members { get; set; } = new List<Person>();

        //  add a person into the family member list
        public void AddMember(Person person)
        {
            Members.Add(person);
        }

        //  return back a count of all family members
        public int Count()
        {
            return Members.Count;
        }
    }
}
