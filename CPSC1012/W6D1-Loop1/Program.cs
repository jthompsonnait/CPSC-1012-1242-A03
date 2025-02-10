namespace W6D1_Loop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int total = 0;
            Console.Write("Enter a number to square and add: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                total = total + (i * i);
            }
            Console.WriteLine($"Your answer is {total}");

            //  while
            int whileNumber = number;
            total = 0;
            while (whileNumber > 0)
            {
                total = total + (whileNumber * whileNumber);
                whileNumber = whileNumber - 1;
            }
            Console.WriteLine($"While - Your answer is {total}");

            //  do while
            int doWhileNumber = number;
            total = 0;
            do
            {
                total = total + (doWhileNumber * doWhileNumber);
                doWhileNumber = doWhileNumber - 1;
            } while (doWhileNumber > 0);
           
            Console.WriteLine($"While - Your answer is {total}");
        }
    }
}
