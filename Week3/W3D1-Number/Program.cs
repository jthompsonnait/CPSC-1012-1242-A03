namespace W3D1_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week 3 - Day 1
            // Course: CPSC1012 - Programming Fundamentals
            // Instructor: James Thompson
            // Exercise: Numbers
            // Author: James Thompson



            //   data types
            //   cost of pop
            double popCost = 1.89;

            //  output pop cost
            Console.WriteLine($"The price of pop is {popCost}");

            // we are converting the data type
            int newPopCost = (int)1.99999999;
            //  string interpolation
            Console.WriteLine($"The new price of pop is {newPopCost}");

            // double
            double coffeeCost = 1;
            // because the "coffeeCost" is a double,
            //   it can store a double value and int
            coffeeCost = coffeeCost + .50;
            //  string interpolation
            Console.WriteLine($"The coffee cost is {coffeeCost}");

            //   GST
            const double GST_RATE = 0.05;
            //  the following will fail if we uncomment it due to the GST_RATE is a constant
            // GST_RATE = 0.07;






        }
    }
}
