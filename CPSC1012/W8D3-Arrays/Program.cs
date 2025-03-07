namespace W8D3_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName ="James";
            string lastName = "Thompson";
            string fullname = string.Empty;

            // create an array of 3 items
            int[] array = new int[] { 1, 2, 3 };

            // print array
            PrintArray(array);

            //  add 5 to our array and have the method print the value
            //  NOTE: Arrays are treated like reference types and the value is updated within the method
            AddFiveToArrayAndPrint(array);

            // print array
            PrintArray(array);

           fullname =  CombineName(firstName, lastName);
        }

        static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        static void AddFiveToArrayAndPrint(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = myArray[i] +5;
            }
            PrintArray(myArray);
        }

        static string CombineName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
