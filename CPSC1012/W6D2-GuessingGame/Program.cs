using static System.Runtime.InteropServices.JavaScript.JSType;

namespace W6D2_GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  create a game to ask for a number between 1 and 100
            //  create a random number 
            //  If the random number is lower than the user input (guess),
            //      then we will tell the user that their number is high
            //  If the random number is higher than the user input (guess),
            //      then we will tell the user that their number is low
            //  If the user guess the right answer, we will let them know

            //  random object
            Random random = new Random();
            int number = random.Next(1, 101);
            Console.WriteLine(number);
            int userInput = 0;
            do
            {
                Console.Write("Input a number between 1 and 100.  Enter 0 to Quit: ");
                userInput = int.Parse(Console.ReadLine());
                if (userInput < 0 || userInput > 100)
                {
                    Console.WriteLine("Your number must be between 1 and 100");
                }
                else
                if (number < userInput)
                {
                    Console.WriteLine("Your number is too high");
                }
                else if (number > userInput)
                {
                    Console.WriteLine("Your number is too high");
                }
            } while (number != userInput && userInput != 0);

            Console.WriteLine("You got it right!!!!");
        }
    }
}
