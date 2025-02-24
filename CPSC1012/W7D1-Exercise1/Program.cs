namespace W7D1_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int[] values = new int[25];
            bool cont = true;
            double total = 0;
            int count = 0;
            do
            {
                Console.Write("Please enter in a number: ");
                int.TryParse(Console.ReadLine(), out value);
                if (value != 0 && count < 25)
                {
                    values[count] = value;
                    count += 1;
                }
                else
                {
                    cont = false;
                }
            } while (cont);

            foreach (var i in values)
            {
                total = total + i;
            }
            Console.WriteLine($"You enter {count} values and the average is {total / count}");
        }
    }
}
