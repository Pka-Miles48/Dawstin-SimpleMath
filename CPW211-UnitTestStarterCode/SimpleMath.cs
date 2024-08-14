using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double firstNumber, double secondNumber)
        {
            // Adding two numbers and returning the result
            return firstNumber + secondNumber;
        }

        public static double Subtract(double minuend, double subtrahend)
        {
            // Subtracting the second number from the first and returning the result
            return minuend - subtrahend;
        }

        public static double Multiply(double multiplicand, double multiplier)
        {
            // Multiplying two numbers and returning the product
            return multiplicand * multiplier;
        }

        public static double Divide(double dividend, double divisor)
        {
            // Checking if the divisor is zero to prevent division by zero
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            // Dividing the first number by the second and returning the quotient
            return dividend / divisor;
        }
    }
}
