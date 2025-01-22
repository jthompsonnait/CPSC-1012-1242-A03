using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_Number
{
    internal class NumberComments
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

        Example:
        int result1 = 6 * 5 - 3;  // 27
        int result2 = 6 * (5 - 3); // 12
        */

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

        /*
        ========================================
        Increment (`++`) & Decrement (`--`) Operators
        ========================================
        - Post-increment: x++ (returns value before incrementing)
        - Pre-increment: ++x (increments before returning value)

        Example:
        int x = 5;
        Console.WriteLine(x++); // 5 (then x becomes 6)
        Console.WriteLine(++x); // 7 (x is incremented first)
        */

        /*
        ========================================
        Math Class Methods for Advanced Arithmetic
        ========================================
        | Method         | Description      | Example            | Output  |
        |----------------|------------------|--------------------|---------|
        | Math.Sqrt(x)   | Square root      | Math.Sqrt(25);     | 5.0     |
        | Math.Pow(x, y) | Power            | Math.Pow(2, 3);    | 8.0     |
        */

        /*
        ========================================
        Formatting Output
        ========================================
        - Use placeholders and decimal formatting for better readability.

        | Format Code | Description                          | Example                               | Output  |
        |-------------|--------------------------------------|---------------------------------------|---------|
        | `{0:N2}`    | Formats number with 2 decimal places | Console.WriteLine("{0:N2}", 123.456); | 123.46  |
        | `{0:C}`     | Formats number as currency           | Console.WriteLine("{0:C}", 123.456);  | $123.46 |
        */

        /*
        ========================================
        Summary
        ========================================
        - Arithmetic operations follow standard operator precedence.
        - Integer division truncates decimals; use modulus `%` for remainders.
        - Use `Math` methods for advanced calculations.
        - Format output using placeholders for readability.
        */

    }
}
