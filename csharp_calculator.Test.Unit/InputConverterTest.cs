using System;
using Xunit;

namespace csharp_calculator.Test.Unit
{
    public class ConvertedInputTest
    {
        private readonly InputConverter inputConverter = new InputConverter();

        [Fact]
        public void PassConvertedInputTest()
        {
            string input = "6";
            Assert.Equal(6, inputConverter.ConvertToNumeric(input));
        }
       

        [Fact]
        public void FailConvertNumericTest()
        {
            string input = "*";
            Assert.Throws<ArgumentException>(() => inputConverter.ConvertToNumeric(input));
        }
    }
}
