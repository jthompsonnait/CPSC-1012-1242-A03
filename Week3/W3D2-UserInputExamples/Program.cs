namespace W3D2_UserInputExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user information
            string firstName;
            string lastName;
            string city;
            int age;

            // ask a question of what is your first name
            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();

            // ask a question of what is your last name
            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();

            //  ask a question of what is your city
            Console.Write("What is your city? ");
            city = Console.ReadLine().ToUpper();

            // ask a question for the age
            Console.Write("What is your age? ");
            age = int.Parse(Console.ReadLine());

            //  output user information
            Console.WriteLine($"Hello {firstName} {lastName}, nice to meet you!");
            Console.WriteLine($"Hope you are enjoying {city}");
            Console.WriteLine($"You are {age} year old");

            //  adds a carriage return (blank line)
            Console.WriteLine();
            Console.WriteLine("***** User Information *****");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
