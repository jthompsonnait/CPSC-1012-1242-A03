namespace W8D2_Test
{
    internal class Program
    {
        static int globalNumber = 10; // Global scope
        static void Main(string[] args)
        {
            Console.WriteLine(globalNumber);
            globalNumber = 15;
            Console.WriteLine(globalNumber);
            //  create array (list of int)
            int[] array = new int[] { 1, 2, 3 };
            ModifyArrayElements(array);
            Console.WriteLine(globalNumber);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                //  6, 7, 8
            }

            //  method for modify an array of integer
            static void ModifyArrayElements(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] += 5; // Add 5 to each element
                }
                globalNumber = 25;
            }
        }
    }
}

