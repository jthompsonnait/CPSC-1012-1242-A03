namespace W12D3_StaticMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare our 2 values
            double x = 30;
            double y = 15;
            double total = 0;

            //  call our static class
            total = SimpleMath.Add(x, y);
            Console.WriteLine($"{x} + {y} = {total}");

            try
            {
                //  reset y to zero
                y = 0;
                //  throw an error by div by zero
                total = SimpleMath.Div(x, y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
