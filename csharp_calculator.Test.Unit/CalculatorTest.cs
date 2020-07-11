using System;
using Xunit;

namespace csharp_calculator.Test.Unit
{
    public class CalculatorTest
    {
        private readonly Calculator calculator = new Calculator();

        [Fact]
        public void CalculateAddTest()
        {
            double number1 = 1.1;
            double number2 = 2.1;
            double expectedResult = 3.2;
            double result = calculator.Calculate("add", number1, number2);

            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void CalculateSubtractTest()
        {
            double number1 = 100;
            double number2 = 9;
            double expectedResult = 91;
            double result = calculator.Calculate("subtract", number1, number2);

            Assert.Equal(expectedResult, result);

        }
    }
}
