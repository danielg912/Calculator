using System;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1)]
        public void CalculatorAdds(int number1, int number2)
        {
            // Arrange
            Calculator calculator = new Calculator();


            // Act

            // Assert
        }
    }
}
