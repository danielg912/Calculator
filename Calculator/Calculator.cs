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

        public int Exponents(int number)
        {
            return number * number;
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
