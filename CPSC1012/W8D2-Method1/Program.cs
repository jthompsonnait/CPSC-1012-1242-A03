namespace W8D2_Method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add(5, 10);
            // PrintMultipleTimes("James", 5);

            
            int x = 0;
            int y = 0;
            int result = 0;
            double d1 = 0;
            double d2 = 0;
            double resultDouble = 0;
            string s1 = String.Empty;
            string s2 = string.Empty;
            string resultString = string.Empty;

            //  using subtract method
            Console.Write("Please enter in the first integer value: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.Write("Please enter in the second integer value: ");
            int.TryParse(Console.ReadLine(), out y);
            //  use the subtraction method
            //  result = x - y
            result = Subtract(x, y);
            Console.WriteLine($"Value {y} subtracted from value {x} equals {result}");
            DottedLineBreak();
            result = Multiple(x, y);
            Console.WriteLine($"Value {x} multiple value {y} equals {result}");
            DottedLineBreak();
            //  methods with different signatures (parameters)
            result = Add(x, y);
            Console.WriteLine($"Int {x} plus Int {y} equals {result}");
            DottedLineBreak();
            //  enter a double
            Console.Write("Please enter in the first double value: ");
            double.TryParse(Console.ReadLine(), out d1);
            Console.Write("Please enter in the second double value: ");
            double.TryParse(Console.ReadLine(), out d2);

            //  adding doubles using results
            resultDouble = Add(d1, d2);
            Console.WriteLine($"Double {d1} plus Double {d2} equals {resultDouble}");
            Console.WriteLine($"Double {d1} plus Double {d2} using the 'Add Method' {Add(d1, d2)}");
            DottedLineBreak();
            //  add two strings
            Console.Write("Please enter in the first string: ");
            s1 = Console.ReadLine();
            Console.Write("Please enter in the second string: ");
            s2 = Console.ReadLine();

            //  adding doubles using results
            resultString = Add(s1, s2);
            Console.WriteLine($"String {s1} plus string {s2} equals {resultString}");


        }

        //  simple no parameter method
        static void DottedLineBreak()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }

        //  add two numbers together and output the answer in the method
        static void AddAndPrint(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"Value {x} added to value {y} equals {result}");
        }

        //  add without storing the results
        static int Add(int x, int y)
        {
            return x + y;
        }

        //  adding doubles
        static double Add(double x, double y)
        {
            return x + y;
        }

        static string Add(string x, string y)
        {
           // return x + " " + y;
           return $"{x} {y}";
        }



        //  subtraction using a variable for storing the results
        static int Subtract(int x, int y)
        {
            int result = x - y;
            return result;
        }

        //  multiple without storing the results
        static int Multiple(int x, int y)
        {
            return x * y;
        }




        static void PrintMultipleTimes(string s, int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine($"{i} -> {s}");
            }
        }


        static void Print(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine();
        }
    }
}
