namespace W7D2_JanProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sumTotal = 0;
            int numberInput = 0;
            int[] logicalArray = new int[10];
            int logicalSize = 0;



            for (int i = 0; i < logicalArray.Length; i++)
            {

                Console.Write("Please enter a number to sum (0 to exit): ");
                numberInput = int.Parse(Console.ReadLine());
                if (numberInput == 0)
                {
                    break;
                }
                logicalArray[logicalSize++] = numberInput;
                sumTotal = sumTotal + numberInput;
                Console.WriteLine($"You Entered: {numberInput} and Sum is: {sumTotal}");
                
            }

            int averageTotal = sumTotal / (logicalSize);
            Console.WriteLine($"You have Entered {(logicalSize)} numbers \tYour Final Total is: {sumTotal} \tThe average: {averageTotal}");

        }
    }
}
