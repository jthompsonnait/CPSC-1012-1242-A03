using System.Xml.Linq;

namespace W9D3_Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Create a program that will ask the user to enter a first name, last name, and an ID number.
            //  The three values should be written to a file in a CSV format.
            //  Prompt the user for the file name.
            string firstName = string.Empty;
            string lastName = string.Empty;
            //  possible ID as examples
            //  SIN ###-###-### Dispay -> 311-922-987 stored -> 311922987 
            //      issues is of we have 088-212-123 stored -> 88212123 (lost the zero)
            int idNumber = 0;
            string fileName = string.Empty;

            try
            {
                Console.Write("Enter the file name as a .csv: ");
                fileName = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(fileName))
                {
                    throw new Exception("File name is required");
                }
                string subString = string.Empty;

                // even better way
                if (!fileName.ToLower().EndsWith(".csv"))
                {
                    fileName += ".csv";
                }


                /*
                    //  better way
                    if (fileName.ToLower().Contains(".csv") == false)
                    {
                        fileName += ".csv";
                    }
 
                    // Good way
                    if (fileName.Length > 3)
                    {
                        subString = fileName.Substring(fileName.Length - 4, 4);
                    }
                    if (subString.ToLower() != ".csv")
                    {
                        fileName += ".csv";
                    }
                
                    //  not as clean as the good way
                    if (fileName.Length < 4 || fileName.Substring(fileName.Length - 4, 4) != ".csv")
                    {
                        fileName += ".csv";
                    }
                */

                Console.Write("Enter the first name: ");
                firstName = Console.ReadLine();
                Console.Write("Enter the last name: ");
                lastName = Console.ReadLine();
                Console.Write("Enter a ID number: ");
                int.TryParse(Console.ReadLine(), out idNumber);
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine($"FirstName,LastName,ID");
                    writer.WriteLine($"{firstName},{lastName},{idNumber}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }
        }
    }
}
