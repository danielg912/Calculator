using System;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1, 2)]
        public void CalculatorAdds(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();


            // Act
            int actual = calculator.Add(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        public void CalculatorSubtracts(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 3, 9)]
        public void CalculatorMultiplies(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        public void CalculatorDivides(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Divide(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 25)]
        public void CalculatorTakesExponent(int number1, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Exponents(number1);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
