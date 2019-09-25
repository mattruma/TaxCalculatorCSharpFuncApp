namespace TaxCalculatorCSharpFuncApp
{
    public interface ITaxCalculate
    {
        decimal Calculate(
            TaxCalculateOptions taxCalculateOptions);
    }
}
