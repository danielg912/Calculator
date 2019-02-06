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
        [InlineData(2, 2, 4)]
        public void CalculatorSubtracts(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
