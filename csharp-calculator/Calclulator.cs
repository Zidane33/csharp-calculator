using System;
namespace csharp_calculator
{
    public class Calculator
    {
        public double Calculate(string operation, double numberOne, double numberTwo)
        {
            double result;
            switch(operation.ToLower())
            {
                case "add":
                case "+":
                    result = numberOne + numberTwo;
                    break;
                case "subtract":
                case "minus":
                case "-":
                    result = numberOne - numberTwo;
                    break;
                case "multiply":
                case "times":
                case "*":
                    result = numberOne * numberTwo;
                    break;
                case "divide":
                case "/":
                    result = numberOne / numberTwo;
                    break;
                default:
                    throw new InvalidOperationException("Expected Valid Operation");

            }
            return result;
        }
    }
}
