﻿namespace W3D2_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ========================================
                Operator Precedence in C#
                ========================================
                C# follows BODMAS/PEMDAS rules:
                1. Brackets/Parentheses () – Highest precedence
                2. Exponents/Powers ^ – Not a direct operator in C#, use Math.Pow()
                3. Division & Multiplication / * – Evaluated from left to right
                4. Addition & Subtraction + - – Evaluated last
            */

            //  Brackets/Parentheses () – Highest precedence
            Console.WriteLine(6 * 5 - 3); //  27
            Console.WriteLine(6 * (5 - 3)); // 12

            /*
                ========================================
                Common Arithmetic Operators in C#
                ========================================
                | Operator | Description      | Example                 | Output |
                |----------|------------------|-------------------------|--------|
                | `+`      | Addition         | int sum = 5 + 3;        | 8      |
                | `-`      | Subtraction      | int diff = 10 - 4;      | 6      |
                | `*`      | Multiplication   | int product = 7 * 2;    | 14     |
                | `/`      | Division         | int quotient = 20 / 4;  | 5      |
                | `%`      | Modulus (Remainder) | int remainder = 10 % 3; | 1      |
        */
            //  Common Arithmetic Operators in C#
            Console.WriteLine(7 * 3);  // 21
            Console.WriteLine(30 / 5);  // 6
            Console.WriteLine(5 + 8);  // 13
            Console.WriteLine(10 - 5); // 5

            /*
                ========================================
                Integer Division & Modulus
                ========================================
                - Integer division discards decimals.
                - Use modulus `%` to get the remainder.

                Example:
                int divResult = 19 / 5; // 3
                int modResult = 19 % 5; // 4
            */
            Console.WriteLine(13 % 3); // 1 -> Remainer form 13 - (3 * 4)
            // Division of uneven number
            Console.WriteLine(13 / 3);  // 4 -> 13 div by 3 only goes into 13 Four times


            /*
                ========================================
                Assignment Operators
                ========================================
                | Operator | Description         | Example               | Output  |
                |----------|---------------------|-----------------------|---------|
                | `+=`     | Add and assign      | int x = 10; x += 2;   | 12      |
                | `-=`     | Subtract and assign | int x = 10; x -= 2;   | 8       |
                | `*=`     | Multiply and assign | int x = 10; x *= 2;   | 20      |
                | `/=`     | Divide and assign   | int x = 10; x /= 2;   | 5       |
            */

            Console.WriteLine();
            Console.WriteLine("Assignment Operators");
            int num = 10;
            //  not using assignment operator
            num = num + 2;
            Console.WriteLine(num);  // 12

            //  using assignment operator
            num += 5;  // 17
            Console.WriteLine(num);  // 17

            //  using modulus operator
            num %= 5;  // 2
            Console.WriteLine(num);  // 2

            //  using the math class for advanced arithmetic
            //  square root
            //  square root of 9 is 3 (3 * 3 = 9)
            //  square root of 25 is 5 (5 * 5 = 25)
            int squareRootNum = 25;
            double squareRootResult = Math.Sqrt(squareRootNum);
            Console.WriteLine($"The square root of {squareRootNum} is {squareRootResult}");

            squareRootNum = 47;
            squareRootResult = Math.Sqrt(squareRootNum);
            Console.WriteLine($"The square root of {squareRootNum} is {squareRootResult}"); //6.855654600401044
            //  using decimal formatting for better readablility
            Console.WriteLine($"The square root of {squareRootNum} to 2 decimal places is {squareRootResult:N2}");

            //  squaring a number (power of)
            //  3 and we square, we will get 9
            //  10 and we square, we will get 100
            double squareNum = 3;
            double powerResult = Math.Pow(squareNum, 2);  //  number we wish to power, and the power of.
            Console.WriteLine($"The square of {squareNum} is {powerResult}"); // 9
            powerResult = Math.Pow(squareNum, 3);  //  cube the number powerResult * powerResult * powerResult
            Console.WriteLine($"The cube of {squareNum} is {powerResult}"); // 27

        }
    }
}
