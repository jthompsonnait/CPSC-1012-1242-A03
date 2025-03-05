namespace W8D2_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string label = string.Empty;
            int result = 0;
            double ticketPrice = 0;
            Console.Write("Please enter in a number as a string one through four: ");
            //label = Console.ReadLine();
            //result = PromptForInt(label);
            result = PromptForAgeGroup(Console.ReadLine());

            // PromptForInt(Console.ReadLine());
            Console.WriteLine($"Your result is {result}");
            try
            {
                ticketPrice = GetPriceByAgeGroup(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
            Console.WriteLine($"Your ticket price is {ticketPrice:C}");
            Console.ReadKey();
        }

        //  int PromptForInt(string label)
        //  that will display the Label to the user and return the integer that they enter.
        static int PromptForAgeGroup(string label)
        {
            switch (label.ToUpper())
            {
                case "ONE":
                    return 1;
                    break;
                case "TWO":
                    return 2;
                    break;
                case "THREE":
                    return 3;
                    break;
                case "FOUR":
                    return 4;
                    break;
                default:
                    return 0;
            }
        }

        static double GetPriceByAgeGroup(int ageGroup)
        {
            switch (ageGroup)
            {
                case 1:
                    return 0;
                    break;
                case 2:
                    return 9.80;
                    break;
                case 3:
                    return 11.35;
                    break;
                case 4:
                    return 10.00;
                    break;
                default:
                    throw new Exception("Unknown Age Group");
            }
        }

        //The price of
        //    admission is based on the age of the customer.Your program should prompt the user for the
        //    type of ticket they would like to purchase and then display the correct admission amount.
        //      1. Children 6 and under = FREE($0.00)
        //      2. Students 7 to 17 = $9.80
        //      3. Adults 18 to 54 = $11.35
        //      4. Seniors 55+ = $10.00
        //Your program should make use of a method TicketPrice(int option) that will return the price of
        //    the ticket based on the passed in menu option. It should also use a method DisplayMenu() that
        //    will display the menu of options to the user.
        //    Make use of the PromptForInt function defined previously. Be aware that you will have to deal
        //with the possibility of the user entering a value that cannot be converted into an integer.
    }
}
