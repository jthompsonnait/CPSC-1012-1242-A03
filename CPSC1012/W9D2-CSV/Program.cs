namespace W9D2_CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  define the filename for the CSV file
            string fileName = "People.csv";

            // empty string for storing each line of data
            string line = string.Empty;

            try
            {
                //  using stream writer to create and write to the csv file
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    //  declare variables for first name, last name and age
                    string firstName = string.Empty;
                    string lastName = string.Empty;
                    int age = 0;


                    //  write the reader row to the CSV file
                    writer.WriteLine("First Name, Last Name, Age");

                    //  generate and write 5 random records to the file
                    for (int i = 0; i < 5; i++)
                    {
                        // generate a random first name with 5 characters
                        firstName = GenerateName(5);

                        // generate a random first name with 8 characters
                        lastName = GenerateName(8);

                        //  generate a random age between 10 and 75 (74)
                        age = new Random().Next(10, 75);

                        //  format the line as a CSV header
                        line = $"{firstName},{lastName},{age}";

                        // write the record to the csv file
                        writer.WriteLine(line);
                        //  condense line
                        //  writer.WriteLine($"{firstName},{lastName},{age}");
                        //  harder to read, not recommended 
                        //  writer.WriteLine($"{GenerateName(5)},{GenerateName(8)},{new Random().Next(10, 75)}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }

            //  check if the file exists before attempting to read it.
            if (File.Exists(fileName))
            {
                try
                {
                    //  read all lines from the file into a string array
                    string[] lines = File.ReadAllLines(fileName);

                    //  print initial information about the file
                    //  display the total number of lines in the file
                    Console.WriteLine($"Number of lines/rows: {lines.Length}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong: {ex.Message}");
                }
            }

        }


        #region Helper Methods
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
        #endregion
    }
}
