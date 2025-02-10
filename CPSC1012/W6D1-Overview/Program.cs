namespace W6D1_Overview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  while loop
            int start = 1;
            while (start <=5)
            {
                //  outputting the value of i
                Console.WriteLine($"Pre-condition loop (while): i = {start}");
                //incrementing i
                start++;
            }
            Console.WriteLine();
            Console.WriteLine();
            //  using a bool for the while loop
            start = 1;
            bool isEqualToFive = false;  // same ->  bool isEqualToFive;
            while (isEqualToFive == false)
            {
                //  outputting the value of i
                Console.WriteLine($"Pre-condition loop (while): i = {start}");
                //incrementing i
                start++;
                if (start == 5)
                {
                    isEqualToFive = true;
                }
            }


            //Console.WriteLine();
            //Console.WriteLine();
            ////  input validation with while
            //string input = string.Empty;
            //while (input != "YES")
            //{
            //    Console.Write("Enter 'yes' to continue: ");
            //    input = Console.ReadLine().ToUpper();
            //}
            //Console.WriteLine("You enter 'yes'!");

            //  for loop count up
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Counting Up: {i}");
            }

            //  for loop count down
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"Counting Down: {i}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //  for do while
            int number = 1;
            do
            {
                Console.WriteLine($"Do While: {number}");
                number++;
            } while (number <= 10);

            Console.WriteLine();
            Console.WriteLine();

            // while loop that never ends
            int infiniteLoop = 1;
            while (infiniteLoop <= 5)
            {
                Console.WriteLine("This loop never ends!");
                // infiniteLoop++ // missing increment!

            }
        }
    }
}
