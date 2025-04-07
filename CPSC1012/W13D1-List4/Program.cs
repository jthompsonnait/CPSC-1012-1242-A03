namespace W13D1_List4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  create a list of person
            List<Person> people = new List<Person>();
            //  create a person
            Person person = new Person("james", "Thompson", 21);
            //  add the person to people
            people.Add(person);

            //  create and add 2 new person
            person = new Person("Mike", "Johnson", 44);
            people.Add(person);

            person = new Person("Sue", "Apple", 55);
            people.Add(person);

            foreach (Person p in people)
            {
                p.DisplayPerson();
            }

            Person me = default!;
            foreach (Person p in people)
            {
                if (p.FirstName == "Mike")
                {
                    // me = p;
                }
            }

            me = people.Where(x => x.FirstName == "Mike")
                .Select(x => x).FirstOrDefault();


            me.DisplayPerson();



        }
    }
}
