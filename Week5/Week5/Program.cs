namespace W5D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  list of number for use in character array
            string numbers = "12345";
            Console.WriteLine(numbers);
            Console.WriteLine($"The first character is {numbers[2]}");

            //  get user name
            Console.Write("Enter in your full name: ");
            string fullName = "James"; //Console.ReadLine();

            //  output first letter of name
            Console.WriteLine($"The first letter of your name is {fullName[0]}");
            //  output the length of the name
            Console.WriteLine($"The length of your fullname is {fullName.Length}");
            //  output last letter of name
            Console.WriteLine($"The last letter of your name is {fullName[fullName.Length-1]}");

            string sub = "Hello World!";
            // store "Hello" in sub1
            string sub1 = sub.Substring(0, 5);
            Console.WriteLine(sub1);

            // store "World!" in sub2
            string sub2 = sub.Substring(6);
            Console.WriteLine(sub2);

            // uppercase
            string up1 = sub.ToUpper();
            Console.WriteLine(up1);

            // lowercase
            string low1 = sub.ToLower();
            Console.WriteLine(low1);

            // trim
            string badString = "   The Dog   ";
            Console.WriteLine($"The bad string is {badString}.");
            string goodString = badString.Trim();
            Console.WriteLine($"The good string is {goodString}.");

            // replace
            string rp1 = goodString.Replace("Dog", "Cat");
            Console.WriteLine($"The new string is {rp1}.");
            //  replace all spaces with nothing
            string rp2 = rp1.Replace(" ", string.Empty);
            Console.WriteLine($"No spaces in string is {rp2}");
            //  replace all spaces with "-" for the entire string
            Console.WriteLine($"No spaces in string is {rp2}".Replace(" ", "-"));



        }
    }
}
