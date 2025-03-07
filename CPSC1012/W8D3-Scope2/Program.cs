using static System.Runtime.InteropServices.JavaScript.JSType;

namespace W8D3_Scope2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // number we are using to show scope
            int number = 5;
            Console.WriteLine($"Number before changes: {number}");
            //  run ShowNumberAsValueType (copy of the number, not the orginial object)
            ShowNumberAsValueType(number);
            //  because we are using number as a value type, number does not change
            Console.WriteLine($"Number after running ShowNumberAsValueType: {number}");

            //  run ShowNumberAsReferenceType (the orginial object is being pass into the method)
            //  need to include the key word "ref".
            ShowNumberAsReferenceType(ref number);
            //  because we are using number as a reference type, number does change
            Console.WriteLine($"Number after running ShowNumberAsReferenceType: {number}");
        }

        static void ShowNumberAsValueType(int number)
        {
            number = number + 5;
            Console.WriteLine($"Number within ShowNumberAsValueType: {number}");
        }

        //  need to include the key word "ref".
        static void ShowNumberAsReferenceType(ref int number)
        {
            number = number + 12;
            Console.WriteLine($"Number within ShowNumberAsReferenceType: {number}");
        }
    }
}
