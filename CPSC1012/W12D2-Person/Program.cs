namespace W12D2_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  use the constructor for our person class
            Person person = new Person("james", "Thompson", 21,22.0/7.0);
            person.DisplayPerson();

            //Person bestFriend = new Person("Ross", "Hodgson", 60,1);
            //bestFriend.DisplayPerson();

            //try
            //{
            //    Person badPerson = new Person("John", "Smith", 1, 1);
            //    badPerson.DisplayPerson();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
          

        }
    }
}
