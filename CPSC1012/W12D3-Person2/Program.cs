namespace W12D3_Person2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  default constructor
            Person2 defaultPerson = new();
          //  defaultPerson.SIN = "123456789";
            defaultPerson.FirstName = "James";
            defaultPerson.LastName = "Thompson";
            // address is not accessable to us using the property
            // defaultPerson.Address = "123 Main Street";
            defaultPerson.DisplayPerson();
            Console.WriteLine("-------------------------");
            //  greed constructor
            Person2 greedPerson = new Person2("987654321", "Bob", "Jones", "123 Main Street");
            greedPerson.DisplayPerson();
            Console.WriteLine("-------------------------");

            try
            {
                //  fail
                //  changing the sin number
                // greedPerson.SIN = "55555555555";
                greedPerson.FirstName = "55555555555";
                greedPerson.DisplayPerson();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            




        }
    }
}
