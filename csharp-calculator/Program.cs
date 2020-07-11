using System;

namespace csharp_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                Calculator calclulator = new Calculator();

                Console.WriteLine("Enter a number");
                double firstNumber = inputConverter.ConvertToNumeric(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                double secondNumber = inputConverter.ConvertToNumeric(Console.ReadLine());
                Console.WriteLine("Enter an operation");
                string operation = Console.ReadLine();

                double result = calclulator.Calculate(operation, firstNumber, secondNumber);
                
                Console.WriteLine(result);
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
           }
        }
    }
}
