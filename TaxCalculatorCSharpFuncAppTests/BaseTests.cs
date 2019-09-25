using Microsoft.Extensions.Logging;
using TaxCalculatorCSharpFuncAppTests.Helpers;

namespace TaxCalculatorCSharpFuncAppTests
{
    public abstract class BaseTests
    {
        protected readonly ILogger _logger = LoggerHelper.CreateLogger(LoggerTypes.List);
    }
}
