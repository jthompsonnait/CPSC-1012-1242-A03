namespace W3D1_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week 3 - Day 1
            // Course: CPSC1012 - Programming Fundamentals
            // Instructor: James Thompson
            // Exercise: Strings
            // Author: James Thompson

            //  this is a comment
            //  it is for humans.
            //  the following statements are demonstrating the
            //      difference between Write and WriteLine
            Console.WriteLine("Welcome to CPSC-1012");
            Console.Write("What's up? ");
            Console.WriteLine("Today is Monday");

           /*
                here are examples of some "escape sequences"
                \n means "new line"
                \t means "tabs" or "indent"
           */

            Console.Write("Here is a list: \n");
            Console.Write("\tFirst Item\n\tSecond Item\n\tLast Item");

            //  let's create some variables!
            //  variables are named in camelCase
            //  we start with a lowercase letter, any subsequent words
            //      are capitalized

            
            int age;
            
            int canadaPopulation = 41465298;  // as of 2024

            //  set my age  
            age = 50;
            //  output a single empty line
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //  output a statement with my age and Canada populations
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Canada populations as of 2024 is " + canadaPopulation);

            //  let's pretend you are a year older
            age = age + 1;
            //  output new age
            Console.WriteLine("Your age is " + age);
            // here the same thing written with a combined assignment operator:
            age += 1;
            //  output new age
            Console.WriteLine("Your age is " + age + " and Canada population is " + canadaPopulation);
            //  string interpolation
            Console.WriteLine($"Your age is {age} and Canada population is {canadaPopulation}");



        }

    }
}
