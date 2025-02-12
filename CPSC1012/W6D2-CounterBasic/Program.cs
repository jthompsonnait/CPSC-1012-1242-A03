namespace W6D2_CounterBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  adding a new line for a string
            Console.Write("Line 1\nLine2\n");
            //  adding a carriage return for a string
            Console.Write("Line 1\r\nLine2\r\n");
            //  adding a carriage return using environment property
            Console.Write($"Line 1{Environment.NewLine}Line2{Environment.NewLine}");

            //  For Loop
            //  basic pattern for counter control loop
            //  1) Initialization
            //  2) Condition
            //  3) Increment or decrement
            //  for (initialization; condition; increment or decrement)
            //  {...}

            //  simple for loop
            Console.WriteLine("Simple for loop");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            //  add 2 blanks lines
            Console.WriteLine();
            Console.WriteLine();

            //  count down loop
            Console.WriteLine("Count down loop");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            //  add 2 blanks lines
            Console.WriteLine();
            Console.WriteLine();

            //  skipping numbers
            Console.WriteLine("Skipping numbers");
            for (int i = 1; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            //  Common Pitt falls
            //  Infinite loop
            //  Inside our for loop, we do have a valid condition to terminate our loop
            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine($"This loop will run forever ! Current number is {i}");
            //}

            //  Incorrect Initialization
            //  Improperly initializing the loop control variable that can't execute
            //      as expected
            for (int i = 10; i < 5; i++)
            {
                Console.WriteLine("This loop will not run");
            }

            //  Forgetting to Increment/Decrement
            //  Forgetting to update the loop control variable
            //for (int i = 1; i <= 5; )
            //{
            //    Console.WriteLine($"Number: {i}");
            //}

            //  Off by one error
            //  When a loop iterates one too many or one too few times
            //  We only want numbers between 0 - 4
            //  for (int i = 0; i < 5; i++)
            //  for (int i = 0; i <= 4; i++)
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
            }

            //  Not initialization at the right point
            //  This is an issue where your initialization is not started at the
            //      correct location or value
            //  Example.  Enter in your name and print out each character on a
            //              separate line
            //  Starting at the wrong value
            //      for (int i = 1; i < name.Length; i++) // Start @ 1 and not 0
            //      for (int i = 0; i <= name.Length; i++) // loop control variable is out of range
            //Console.Write("Please enter in your name: ");
            //string name = Console.ReadLine();

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //  Inner and outer loop
            //  A loop within a loop
            //  outer loop
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Outer Loop: {i}");
                //  inner loop
                for (int j = 105; j > 100; j--)
                {
                    Console.WriteLine($"Inner Loop: {j}");
                }
            }
        }
    }
}
