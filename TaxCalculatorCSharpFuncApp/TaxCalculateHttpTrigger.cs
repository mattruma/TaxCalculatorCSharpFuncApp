using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace TaxCalculatorCSharpFuncApp
{
    public class TaxCalculateHttpTrigger
    {
        private readonly ITaxCalculate _taxCalculate;

        public TaxCalculateHttpTrigger(
            ITaxCalculate taxCalculate)
        {
            _taxCalculate = taxCalculate;
        }

        [FunctionName("TaxCalculateHttpTrigger")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] TaxCalculateOptions taxCalculateOptions,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var taxAmount =
                _taxCalculate.Calculate(
                    taxCalculateOptions);

            return new OkObjectResult($"The tax amount is {taxAmount:C2}.");
        }
    }
}
