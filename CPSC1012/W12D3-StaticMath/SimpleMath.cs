using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W12D3_StaticMath
{
    //  static class (we do not have to instance the class to use it)
    public static class SimpleMath
    {
        //  simple addition
        public static double Add(double x, double y)
        {
            return x + y;
        }

        //  simple div
        public static double Div(double x, double y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException("You cannot divide by zero");
            }
            return x / y;
        }
    }
}
