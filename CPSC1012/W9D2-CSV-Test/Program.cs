using System.ComponentModel;

namespace W9D2_CSV_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the filename for the CSV file
            string fileName = "People.csv";

            // Initialize an empty string for storing each line of data
            string line = string.Empty;

            try
            {
                // Use StreamWriter to create and write to the CSV file
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Declare variables for first name, last name, and age
                    string firstName = string.Empty;
                    string lastName = string.Empty;
                    int age = 0;

                    // Write the header row to the CSV file
                    writer.WriteLine("First Name, Last Name, Age");

                    // Generate and write 5 random records to the file
                    for (int i = 0; i < 5; i++)
                    {
                        // Generate a random first name with 5 characters
                        firstName = GenerateName(5);

                        // Generate a random last name with 8 characters
                        lastName = GenerateName(8);

                        // Generate a random age between 10 and 75
                        age = new Random().Next(10, 75);

                        // Format the line as CSV (comma-separated values)
                        line = $"{firstName},{lastName},{age}";

                        // Write the formatted line to the CSV file
                        writer.WriteLine(line);
                    }
                } // The 'using' statement ensures the file is properly closed after writing
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }

            //  check if the file exist
            // Check if the file exists before attempting to read it
            if (File.Exists(fileName))
            {
                try
                {
                    // Read all lines from the file into a string array
                    string[] lines = File.ReadAllLines(fileName);

                    //  print initial information and output file

                    // Display the total number of lines in the file
                    Console.WriteLine($"Number of lines: {lines.Length}");

                    // Insert a blank line for better readability
                    CreateBlankLines(1);

                    // Since the first line is the header, subtract 1 to get the number of records (people)
                    Console.WriteLine($"Number of person/records: {lines.Length - 1}");

                    // Insert another blank line for spacing
                    CreateBlankLines(1);

                    // Output the header row
                    string[] items = lines[0].Split(','); // Split header row by commas

                    // Print the column headers with tab spacing
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.Write($"{items[i]}\t");
                    }
                    Console.WriteLine(); // Move to the next line

                    // Output the list of people (skip the header, start at index 1)
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] people = lines[i].Split(','); // Split each line into individual values

                        // Print each person's details with tab spacing
                        for (int j = 0; j < people.Length; j++)
                        {
                            Console.Write($"{people[j]}\t");
                        }
                        Console.WriteLine(); // Move to the next line after each record
                    }

                    CreateBlankLines(2);
                    //  Print Last name and age
                    //  Assuming structure is first name, last name and age

                    Console.WriteLine("Print Last Name and Age");
                    Console.WriteLine("************************");
                    Console.WriteLine("Last Name\t Age");
                    // Output the list of people (skip the header, start at index 1)
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] people = lines[i].Split(','); // Split each line into individual values

                        // Print each person's last name and age with tab spacing
                            Console.WriteLine($"{people[1]}: \t{people[2]}");
                    }
                }
                catch (Exception e)
                {
                    // Handle exceptions gracefully and provide error feedback
                    Console.WriteLine($"Something went wrong: {e.Message}");
                }
            }

            // Insert three blank lines for better formatting after processing
            CreateBlankLines(3);



        }

        public static void CreateBlankLines(int numberOfLines)
        {
            // Ensure that the input is valid (non-negative)
            if (numberOfLines < 0)
            {
                Console.WriteLine("Invalid input: Number of lines cannot be negative.");
                return;
            }

            // Print the specified number of blank lines
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine();
            }
        }

        
        // Generates a random name of a given length.
        public static string GenerateName(int len)
        {
            // Create a new Random instance.
            Random r = new Random();

            // Define consonants and vowels to use in the name generation.
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };

            string Name = "";

            // Start the name with an uppercase consonant and a vowel.
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];

            // Counter for tracking the number of characters added.
            int b = 2;

            // Add alternating consonants and vowels until we reach the desired length.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }
    }
}
