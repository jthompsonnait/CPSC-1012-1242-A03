using System.Diagnostics.CodeAnalysis;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace W7D1_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  array of numbers for storing our running numbers into.
            int[] numbers = new int[25];
            //  input value
            int inputValue = 0;
            //  current count of numbers enter
            int count = 0;
            //  total of all numbers
            double total = 0;
            //  average (total/count) assuming count > 0
            double average = 0;

            //  process number
            for (count = 0; count < 25; count++)
            {
                //  prompt for a number
                Console.Write("Please enter in a number (0 to quit): ");

                //  get the number the user input
                int.TryParse(Console.ReadLine(), out inputValue);
                //  check if the user has enter a zero to quit
                if (inputValue != 0)
                {
                    //  store the number in the current count position
                    numbers[count] = inputValue;
                }
                else
                {
                    //  exit the loop
                    break;
                }
            }


            //  iterate the list 
            /*
            //  using the for loop
            for (int i = 0; i < count; i++)
            {
                //  sum all the number enter
                total = total + numbers[i];
            }
            */
            foreach (var number in numbers)
            {
                //  sum all the number enter
                total = total + number;
            }

            if (count > 0)
            {
                average = total / count;
            }
            Console.WriteLine($"You enter {count} values and the average is {average}");
        }
    }
}
