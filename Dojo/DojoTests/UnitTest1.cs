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
            int numberOne = 2;
            int numberTwo = 3;
            Calculator calculator = new Calculator();
            double result = calculator.Sum(numberOne, numberTwo);
            Assert.Equal(5, result);
        }
        [Fact]
        public void ShouldSubtractTwoNumbersAndReturnSuccess()
        {
            int numberOne = 5;
            int numberTwo = 3;
            Calculator calculator = new Calculator();
            double result = calculator.Subtract(numberOne, numberTwo);
            Assert.Equal(2, result);
        }
        [Fact]
        public void ShouldMultiplyTwoNumbersAndReturnSuccess()
        {
            int numberOne = 5;
            int numberTwo = 3;
            Calculator calculator = new Calculator();
            double result = calculator.Multiply(numberOne, numberTwo);
            Assert.Equal(15, result);
        }
    }
}
