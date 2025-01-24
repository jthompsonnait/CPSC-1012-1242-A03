namespace W3D3_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// data types
            //string str; //  does not require a parse for this data type.
            //Console.Write("Please enter in your name: ");
            //str = Console.ReadLine();
            //Console.WriteLine($"Your name is {str}");

            //char c; // character data type
            //Console.Write("Please enter in a characer: ");
            //c = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Your character was {c}");

            ////   adding numbers that are string together
            //string numString1;
            //string numString2;
            //string resultString;
            //Console.Write("Please enter in the first number: ");
            //numString1 = Console.ReadLine();
            //Console.Write("Please enter in the second number: ");
            //numString2 = Console.ReadLine();
            //resultString  = numString1 + numString2;  // "5" + "1" -> "51"
            //Console.WriteLine($"Your total is {resultString}");

            ////  adding numbers as integers together
            //int num1;
            //int num2;
            //int resultNum;
            //Console.Write("Please enter in the first number: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.Write("Please enter in the second number: ");
            //num2 = int.Parse(Console.ReadLine());
            //resultNum = num1 + num2;  // 5 + 1 -> 6
            //Console.WriteLine($"Your total is {resultNum}");

            ////  convert an existing string to an integer;
            //num1 = Convert.ToInt32(numString1); //  convert a string into a int
            //num2 = int.Parse(numString2); //  convert a string into a int
            //resultNum = num1 + num2;  // 5 + 1 -> 6
            //Console.WriteLine($"Your total from a string to an integer is {resultNum}");

            //  adding numbers as double together
            double d1;
            double d2;
            double resultDoule;
            Console.Write("Please enter in the first double: ");
            d1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter in the second double: ");
            d2 = double.Parse(Console.ReadLine());
            resultDoule = d1 + d2;  // 5.7 + 1.3 -> 7.0
            Console.WriteLine($"Your total is {resultDoule}");

            //  bool
            bool snowing;
            Console.Write("Is it snowing? ");
            snowing = bool.Parse(Console.ReadLine());
            Console.WriteLine($"Is it snowing? {snowing}");
        }
    }
}
