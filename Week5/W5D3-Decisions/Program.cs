namespace W5D3_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter in a radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area;
            //  Two Way if-else statement
            //  check to see if radius is less than zero
            if (radius < 0)
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                //  calculate the area
                area = Math.Pow(radius, 2) * Math.PI;
                //  rounding to 2 decimal places
                Console.WriteLine($"Area is {Math.Round(area, 2)}");
            }

            //  One Way if statement
            //  check to see if radius is greater than zero
            if (radius > 0)
            {
                //  calculate the area
                area = Math.Pow(radius, 2) * Math.PI;
                //  rounding to 2 decimal places
                Console.WriteLine($"The area for the circle of radius {radius} is {Math.Round(area, 2)}");
            }

            //  check if a number is even or odd
            Console.Write("Enter in a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number % 2);
            //  even number
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            //  odd number
            {
                Console.WriteLine($"{number} is odd");
            }

            //  nested if statement
            //  are you hungry
            Console.Write("Are you hungry (y/n): ");
            //  convert to lowercase
            char yesNo = char.Parse(Console.ReadLine().ToLower());

            //  how much money do you have
            Console.Write("How much money do you have? ");
            double money = double.Parse(Console.ReadLine());

            //  check to see if you are hungry
            if (yesNo == 'y')
            {
                //  check amount of money
                if (money > 10)
                {
                    Console.WriteLine("I will buy lunch");
                }
                else
                {
                    Console.WriteLine("No lunch for me!");
                }
            }
            else
            //  not hungry
            {
                Console.WriteLine("I'm not hungry!");
            }

            //  *****  better requirement gathering  *****
            //  nested if statement
            //  are you hungry
            Console.Write("Are you hungry (y/n): ");
            //  convert to lowercase
            char yesNo2 = char.Parse(Console.ReadLine().ToLower());

            //  check to see if you are hungry
            if (yesNo2 == 'y')
            {
                //  how much money do you have
                Console.Write("How much money do you have? ");
                double money2 = double.Parse(Console.ReadLine());
                //  check amount of money
                if (money2 > 10)
                {
                    Console.WriteLine("I will buy lunch");
                }
                else
                {
                    Console.WriteLine("No lunch for me!");
                }
            }
            else
            //  not hungry
            {
                Console.WriteLine("I'm not hungry!");
            }


            //  Convert percent into a mark
            Console.Write("Please enter in a mark: ");
            int percent = int.Parse(Console.ReadLine());

            // use our switch statement to return a mark
            switch (percent)
            {
                case int p when (p >= 80 && p <= 100):
                    Console.WriteLine("Your mark is 'A'");
                    break;
                case >= 65:
                    Console.WriteLine("Your mark is 'B'");
                    break;
                case >= 50:
                    Console.WriteLine("Your mark is 'C'");
                    break;
                case >= 0:
                    Console.WriteLine("Your mark is 'F");
                    break;
                default:
                    Console.WriteLine("Invalid Percent!");
                    break;
            }
            //  Thanks to Julien
            switch (percent)
            {
                case int n when (n >= 80 && n <= 100):
                    Console.WriteLine("Your mark is 'A'");
                    break;
                case int n when (n >= 65 && n < 80):
                    Console.WriteLine("Your mark is 'B'");
                    break;
                case int n when (n >= 50 && n < 65):
                    Console.WriteLine("Your mark is 'C'");
                    break;
                case int n when (n >= 0 && n < 50):
                    Console.WriteLine("Your mark is 'F'");
                    break;
                default:
                    Console.WriteLine("Invalid Percent!");
                    break;
            }
        }
    }
}
