using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(TaxCalculatorCSharpFuncApp.Startup))]
namespace TaxCalculatorCSharpFuncApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            // Add support services

            builder.Services.AddSingleton<ITaxCalculate, TaxCalculate>();
        }
    }
}