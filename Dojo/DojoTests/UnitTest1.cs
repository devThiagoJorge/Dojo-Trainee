using ConsoleDojo;
using System;
using Xunit;

namespace DojoTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldSumTwoNumbersReturnSuccess()
        {
            var numberOne = 2;
            var numberTwo = 3;
            Calculator calculator = new Calculator();
            var sum = calculator.Sum(numberOne, numberTwo);
            Assert.Equal(5,sum);
        }
    }
}
