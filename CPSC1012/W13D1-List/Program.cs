namespace W13D1_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new();
            numbers.Add(1);
            numbers.Add(2);
           

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            for (int i = 5; i <= 10; i++)
            {
                numbers.Add(i);
            }
            Console.WriteLine();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
