using System;

namespace TaxCalculatorCSharpFuncApp
{
    public class TaxCalculate : ITaxCalculate
    {
        public decimal Calculate(
            TaxCalculateOptions taxCalculateOptions)
        {
            if (taxCalculateOptions.TaxableAmount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(taxCalculateOptions.TaxableAmount), "'taxableAmount' must be greater than 0.");
            }

            var taxAmount =
                taxCalculateOptions.TaxableAmount * taxCalculateOptions.TaxRate;

            // This rounds the result to two decimal places, e.g. 6.66666666 becomes 6.67

            return decimal.Round(taxAmount, 2, MidpointRounding.AwayFromZero);
        }
    }
}
