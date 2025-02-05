namespace W5D1_StringPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Substring exercises
            Console.WriteLine("// Substring Exercises");
            string substringExample = "Hello, World!";

            // Show the first 4 characters
           
            // Expected result: "Hell"
            // Your code here
            string s1 = substringExample.Substring(0, 4);
            Console.WriteLine($"First 4 characters: {s1}");


            // Get the "Hello" from the string
            Console.WriteLine("\"Hello\" from the string: ");
            // Expected result: "Hello"
            // Your code here

            // Show everything after the comma
            Console.WriteLine("Everything after the comma: ");
            // Expected result: " World!"
            // Your code here

            // Show the last 6 characters of the string
            Console.WriteLine("Last 6 characters: ");
            // Expected result: "World!"
            // Your code here

            // Length exercises
            Console.WriteLine("\n// Length Exercises");
            string lengthExample = "Hello, World!";

            // Show the length of the string
            Console.WriteLine("Length of the string: ");
            // Expected result: "13"
            // Your code here

            // Determine if the string is longer than 10 characters
            Console.WriteLine("Is the string longer than 10 characters? ");
            // Expected result: "True"
            // Your code here

            // Split exercises
            Console.WriteLine("\n// Split Exercises");
            string splitExample = "apple,banana,cherry";

            // Split the string into an array and print each fruit
            Console.WriteLine("Split and print each fruit: ");
            // Expected results: "apple" "banana" "cherry"
            // Your code here

            // Find the number of words in the string "Hello, World, Again!"
            Console.WriteLine("Number of words in \"Hello, World, Again!\": ");
            // Expected result: "3"
            // Your code here

            // StartsWith exercises
            Console.WriteLine("\n// StartsWith Exercises");
            string startsWithExample = "Hello, World!";

            // Check if the string starts with "Hello"
            Console.WriteLine("Starts with \"Hello\": ");
            // Expected result: "True"
            // Your code here

            // Check if the string starts with "World"
            Console.WriteLine("Starts with \"World\": ");
            // Expected result: "False"
            // Your code here

            // Replace exercises
            Console.WriteLine("\n// Replace Exercises");
            string replaceExample = "Hello, World!";

            // Replace "World" with "C#"
            Console.WriteLine("Replace \"World\" with \"C#\": ");
            // Expected result: "Hello, C#!"
            // Your code here

            // Replace all commas with semicolons
            Console.WriteLine("Replace commas with semicolons: ");
            // Expected result: "Hello; World!"
            // Your code here

            // Trim() exercises
            Console.WriteLine("\n// Trim() Exercises");
            string trimExample = "  Hello, World!  ";

            // Use Trim() to remove all leading and trailing white-space characters
            Console.WriteLine("Use Trim to remove white spaces: ");
            // Expected result: "Hello, World!"
            // Your code here

            // Contains() exercises
            Console.WriteLine("\n// Contains() Exercises");
            string containsExample = "Hello, World!";

            // Check if the string contains "World"
            Console.WriteLine("Check if contains \"World\": ");
            // Expected result: "True"
            // Your code here

            // IndexOf() exercises
            Console.WriteLine("\n// IndexOf() Exercises");
            string indexOfExample = "Hello, World!";

            // Find the index of "World" in the string
            Console.WriteLine("Find the index of \"World\": ");
            // Expected result: "7"
            // Your code here

            // Insert() exercises
            Console.WriteLine("\n// Insert() Exercises");
            string insertExample = "Hello, World!";

            // Insert "Beautiful " before "World"
            Console.WriteLine("Insert \"Beautiful \" before \"World\": ");
            // Expected result: "Hello, Beautiful World!"
            // Your code here

            // String.Format() exercises
            Console.WriteLine("\n// String.Format() Exercises");
            // Use String.Format() to create a formatted string saying "Hello, John Doe!"
            Console.WriteLine("Use String.Format() to greet John Doe: ");
            // Expected result: "Hello, John Doe!"
            // Your code here

            // Interpolated strings exercises
            Console.WriteLine("\n// Interpolated Strings Exercises");
            string name = "John";
            int age = 30;

            // Use interpolated strings to say "John is 30 years old."
            Console.WriteLine("Use interpolated strings to show name and age: ");
            // Expected result: "John is 30 years old."
            // Your code here

            // Verbatim interpolated strings exercises
            Console.WriteLine("\n// Verbatim Interpolated Strings Exercises");
            string filePath = @"C:\Users";
            string fileName = "Report";

            // Use verbatim interpolated strings to combine filePath and fileName
            Console.WriteLine("Use verbatim interpolated strings for file path and name: ");
            // Expected result: "C:\Users\Report"
            // Your code here

        }
    }
}
