using ConsoleDojo;
using System;
using Xunit;

namespace DojoTests
{
    public class CalculatorUnitTest
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

        [Fact]
        public void ShouldDivideTwoNumbersAndReturnSuccess()
        {
            int numberOne = 5;
            int numberTwo = 2;
            Calculator calculator = new Calculator();
            double result = calculator.Division(numberOne, numberTwo);
            Assert.Equal(2.5, result);
        }

        [Fact]
        public void ShouldDivideANumberByZeroFail()
        {
            int numberOne = 5;
            int numberTwo = 0;
            Calculator calculator = new Calculator();
            double result = calculator.Division(numberOne, numberTwo);

            Assert.Equal(3, result);
        }


    }
}
