namespace W8D3_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Swap(x, y);
            Console.WriteLine("Outside method - x: " + x + ", y: " + y); // Output: Outside method - x: 5, y: 10
        }
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Inside method - a: " + a + ", b: " + b); // Output: Inside method - a: {value of b}, b: {value of a}
        }
    }
}
