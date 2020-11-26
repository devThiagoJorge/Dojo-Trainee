using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDojo
{
    public class Calculator
    {
        
        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Division(double number1, double number2)
        {
            return number1 / number2;
        }

        public double SquareRoot(double number)
        {
            double square = Math.Sqrt(number);
            return square;
        }

        public double Power(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
