using System.Numerics;

namespace W6D3_Average
{
    internal class Program
    {
        /// <summary>
        /// Purpose: Allow the user to enter positive numbers until they enter zero.
        /// Display the average of the numbers entered.
        /// </summary>
        static void Main(string[] args)
        {
            //  user input number
            int number = 0;
            //  average of our number
            double average;
            //  count
            int count = 0;
            //  running total
            int runningTotal = 0;

            Console.WriteLine("==== Enter in a whole number until zero ====");
            Console.WriteLine();

            do
            {
                try
                {
                    Console.Write("Enter a positive number, zero to exit: ");
                    // number  = int.Parse(Console.ReadLine());
                    bool result =int.TryParse(Console.ReadLine(), out number);

                    if (number < 0)
                    {
                        throw new Exception("You can't have a negative value");
                    }
                }              
                catch (Exception ex)
                {
                    Console.WriteLine($"You must enter a positive value - {ex.Message}");
                    number = -1;
                }
                // if we have a positive number
                if(number > 0)
                {
                    // sum our running total
                    runningTotal = runningTotal + number;  // runningTotal += number;
                    //  increase our count by 1
                    count = count + 1;  // count++;  count +=1;
                    
                }

            } while (number != 0);

            if (count > 0)
            {
                average = runningTotal / count;
                Console.WriteLine();
                Console.WriteLine($"The average is {average}.");
            }

            Console.WriteLine();
            Console.WriteLine("===== End Program =====");
        }
    }
}
