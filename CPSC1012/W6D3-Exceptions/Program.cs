namespace W6D3_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  ask for a number
            Console.WriteLine("Please enter in a number that is larger than 0.");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            try
            {
                //  answer
                double answer = 10 / number;

                if (answer < 0)
                {
                    throw new Exception("You can't have a negative value");
                }

                //  output our answer
                Console.WriteLine($"10 divide by {number} equals {answer}");

            }            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Opps, why are you dividing by zero! {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Opps, something bad happen! {ex.Message}");
            }
            Console.ReadKey();

        }
    }
}
