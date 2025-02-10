namespace W6D3_Total
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;

            do
            {
                Console.Write("Enter numbers to add (0 to stop): ");
                num = int.Parse(Console.ReadLine());
                //sum += num;
                sum = sum + num;
            } while (num != 0);

            Console.WriteLine($"Total sum: {sum}");
        }
    }
}
