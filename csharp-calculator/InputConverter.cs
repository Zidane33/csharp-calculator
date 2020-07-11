using System;

namespace csharp_calculator
{
    public class InputConverter
    {
        public double ConvertToNumeric(string argInput)
        {
            double convertedNumber;
            if (!double.TryParse(argInput, out convertedNumber)) throw new ArgumentException("Expected Numeric Value");
            return convertedNumber;
        }

    }
}
