using Newtonsoft.Json;

namespace TaxCalculatorCSharpFuncApp
{
    public class TaxCalculateOptions
    {
        [JsonProperty("tax_rate")]
        public decimal TaxRate { get; set; }

        [JsonProperty("taxable_amount")]
        public decimal TaxableAmount { get; set; }
    }
}
