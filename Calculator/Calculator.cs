using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        public double Exponents(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }

        public int Factorial(int number1)
        {
            for (int i = number1 - 1; i > 0; i--)
            {
                number1 *= i;
            }
            return number1;
        }
    }
}
