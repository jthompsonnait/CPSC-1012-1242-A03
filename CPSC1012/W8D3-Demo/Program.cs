using System.Globalization;

namespace W8D3_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the maximum size of the pollution array
            const int POLLUTION_ARRAY_SIZE = 7;

            // Variable to store the actual number of days the pollution information is provided
            int numberOfDays = 0;

            // Declare an array to store up to six pollution level readings
            int[] pollutionLevel = new int[POLLUTION_ARRAY_SIZE];

            // Prompt the user to enter pollution level readings
            Console.WriteLine("Enter the six pollution level readings (enter 0 to stop early): ");

            // Call method to take user input and update pollution levels
            numberOfDays = EnterPollutionInformation(pollutionLevel, POLLUTION_ARRAY_SIZE);

            // Print a separator line for better output readability
            Console.WriteLine("-------------");

            // Display the pollution levels entered by the user
            PrintPollution(pollutionLevel, numberOfDays);

            // Print additional space for clarity in output
            Console.WriteLine();
            Console.WriteLine();

            // Create and display a bar chart based on pollution levels
            CreateBarChart(pollutionLevel, numberOfDays);

        }

        // Method to accept pollution level inputs from the user.
        // The method stops taking input if the user enters 0.        
        static int EnterPollutionInformation(int[] pollutionLevel, int pollutionArraySize)
        {
            // Variable to track the actual number of days data was entered
            int days = pollutionArraySize;
            int pollutionValue = 0;

            // Loop to accept pollution level readings from the user
            for (int index = 0; index < pollutionArraySize; index++)
            {
                // Read and parse user input (ignores invalid inputs)
                int.TryParse(Console.ReadLine(), out pollutionValue);

                // If the entered value is not zero, store it in the array
                if (pollutionValue != 0)
                {
                    pollutionLevel[index] = pollutionValue;
                    days = index + 1; // Update the number of recorded days
                }
                else
                {
                    // If the user enters 0, stop taking inputs
                    days = index;
                    break;
                }
            }

            // Return the actual number of pollution readings recorded
            return days;
        }


        // Method to print the pollution level readings.
        static void PrintPollution(int[] pollutionLevel, int numberOfDays)
        {
            // Loop through the pollution levels and print each value
            for (int index = 0; index < numberOfDays; index++)
            {
                Console.WriteLine($"{pollutionLevel[index]}");
            }

            // Print an empty line for better formatting
            Console.WriteLine();
        }


        // Method to generate and display a bar chart for pollution levels.
        static void CreateBarChart(int[] pollutionLevel, int numberOfDays)
        {
            // Display the bar chart header
            Console.WriteLine("***************************************");
            Console.WriteLine("*************  Bar Chart  *************");
            Console.WriteLine("***************************************");
            Console.WriteLine();

            // Loop through the recorded pollution levels and print bar chart
            for (int i = 0; i < numberOfDays; i++)
            {
                // Print the pollution level value aligned to the right
                Console.Write($"{pollutionLevel[i].ToString().PadLeft(3)} |> ");

                // Print asterisks (*) corresponding to the pollution level value
                for (int j = 1; j <= pollutionLevel[i]; j++)
                {
                    Console.Write("*");
                }

                // Move to the next line after printing the bar for this value
                Console.WriteLine();
            }
        }
    }
}