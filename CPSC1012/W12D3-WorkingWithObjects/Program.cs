namespace W12D3_WorkingWithObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  create the family object
            Family family = new Family();
            //  create a dad object of person
            Person dad = new Person("Frank", "Thompson");
            //  output the full name
            Console.WriteLine(dad.FullName);
            //  add dad to our family
            family.AddMember(dad);
            //  display the count of the number of family members
            Console.WriteLine(family.Count());
        }
    }
}
