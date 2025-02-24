namespace W5D5_IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  enter in a number for a month and have a returning vaue of number of days in that month.
            //  NOTE:   We are only assuming Feb has 28 days

            //  get the month number
            Console.Write("Please enter a number for a month IE: 1 for January: ");
            int month = int.Parse(Console.ReadLine());

            //  showing bad If Statements
            #region Bad if statement
            if (month == 1)
            {
                Console.WriteLine($"For the the month of {month} there are 31 days");
            }
            else
            {
                if (month == 2)
                {
                    Console.WriteLine($"For the the month of {month} there are 28 days");
                }
                else
                {
                    if (month == 3)
                    {
                        Console.WriteLine($"For the the month of {month} there are 31 days");
                    }
                    else
                    {
                        if (month == 4)
                        {
                            Console.WriteLine($"For the the month of {month} there are 30 days");
                        }
                        else
                        {
                            if (month == 5)
                            {
                                Console.WriteLine($"For the the month of {month} there are 31 days");
                            }
                            else
                            {
                                if (month == 6)
                                {
                                    Console.WriteLine($"For the the month of {month} there are 30 days");
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            //  showing good If Statements
            #region Good If Statements
            // check if we have an invalid month
            if (month < 1 || month > 12)
            {
                Console.WriteLine($"The month of {month} is invalid");
            }
            else

                // check for February 
                if (month == 2)
            {
                Console.WriteLine($"For the the month of {month} there are 28 days");
            }
            else

                // check for April, June, September and November 
                if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine($"For the the month of {month} there are 30 days");
            }
            //  all other months
            else
            {
                Console.WriteLine($"For the the month of {month} there are 31 days");
            }
            #endregion


            //  showing with switch
            switch (month)
            {
                case 2:
                    Console.WriteLine($"Switch - For the the month of {month} there are 28 days");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Switch - For the the month of {month} there are 30 days");
                    break;

                // case statement on a single line.
                // case int p when (p == 1 || p == 3 || p == 5 || p == 7 || p == 8 || p == 10 || p == 12):

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Switch - For the the month of {month} there are 31 days");
                    break;

                default:
                    Console.WriteLine($"Switch - The month of {month} is invalid");
                    break;
            }

            //  showing with switch version 2
            switch (month)
            {
                case int p when (p < 1 || p > 12):
                    Console.WriteLine($"Switch - The month of {month} is invalid");
                    break;

                case 2:
                    Console.WriteLine($"Switch - For the the month of {month} there are 28 days");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Switch - For the the month of {month} there are 30 days");
                    break;

                default:
                    Console.WriteLine($"Switch - For the the month of {month} there are 31 days");
                    break;

            }

            Console.ReadKey();
        }
    }
}
