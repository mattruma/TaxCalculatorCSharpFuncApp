using TaxCalculatorCSharpFuncApp;
using Xunit;

namespace TaxCalculatorCSharpFuncAppTests
{
    public class TaxCalculateTests : BaseTests
    {
        [Theory]
        [InlineData(0.06, 5, 0.3)]
        [InlineData(0.06, 10, 0.6)]
        [InlineData(0.06, 50, 3)]
        [InlineData(0.06, 100, 6)]
        [InlineData(0.06, 133, 7.98)]
        [InlineData(0.06, 5000, 300)]
        [InlineData(0.0525, 5, 0.26)]
        [InlineData(0.0525, 10, 0.53)]
        [InlineData(0.0525, 50, 2.63)]
        [InlineData(0.0525, 100, 5.25)]
        [InlineData(0.0525, 133, 6.98)]
        [InlineData(0.0525, 5000, 262.5)]
        public void When_Calculate(
            decimal taxRate,
            decimal taxableAmount,
            decimal expectedTaxAmount)
        {
            // Arrange

            var taxCalculate =
                new TaxCalculate();

            var taxCalculateOptions =
                new TaxCalculateOptions
                {
                    TaxRate = taxRate,
                    TaxableAmount = taxableAmount
                };

            // Act

            var taxAmount =
                taxCalculate.Calculate(
                    taxCalculateOptions);

            // Assert

            Assert.Equal(expectedTaxAmount, taxAmount);
        }
    }
}
