namespace W7D1_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  declaration with size
            int[] numbers = new int[5];
            #region declaration with size
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            #endregion
            // output our numbers
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[4]);

            //  declaration with values
            int[] numbers2 = [60, 70, 80, 90, 100];
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers2[4]);
            //  update 100 with 110
            numbers2[4] = 110;
            Console.WriteLine(numbers2[4]);

            //  output using "for loop"
            for (int i = 0; i < numbers.Length; i++)
            {
               Console.WriteLine($"The index of {i} has a value of {numbers[i]}"); 
            }

            //  output using the foreach loop
            foreach (var number in numbers2)
            {
                Console.WriteLine($"The value is {number}");
            }


            string[] stringArray = ["one", "two", "three"];

            //  output using "for loop"
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"The index of {i} has a value of {stringArray[i]}");
            }

            string name = "James";
            //  output using "for loop"
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"The index of {i} has a value of {name[i]}");
            }
        }
    }
}
