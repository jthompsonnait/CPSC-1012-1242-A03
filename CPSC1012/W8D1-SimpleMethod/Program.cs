namespace W8D1_SimpleMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            //Console.Write("What is your name: ");
            //result = Console.ReadLine();
            //Console.WriteLine(result);
            //Console.WriteLine();
            //Console.Write("What is your age: ");
            //result = Console.ReadLine();
            //Console.WriteLine(result);
            //Console.WriteLine();
            //Console.Write("What city do you live in: ");
            //result = Console.ReadLine();
            //Console.WriteLine(result);
            //Console.WriteLine();

            //  simple method
            //Console.Write("What is your name: ");
            //result = Console.ReadLine();
            //Print(result);
            //Console.Write("What is your age: ");
            //result = Console.ReadLine();
            //Print(result);
            //Console.Write("What city do you live in: ");
            //result = Console.ReadLine();
            //Print(result);

            // more advance method
            PrintAdv("Do you have a brother: ");
            PrintAdv("Do you have a sister: ");
            PrintAdv("Do you have a pets: ");
        }

        static void Print(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine();
        }

        static void PrintAdv(string s)
        {
            string result = string.Empty;
            Console.Write(s);
            result = Console.ReadLine();
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
