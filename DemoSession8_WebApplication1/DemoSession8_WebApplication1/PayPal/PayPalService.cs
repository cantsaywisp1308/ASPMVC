using Microsoft.Extensions.Configuration;

namespace DemoSession8_WebApplication1.PayPal
{
    public class PayPalService
    {
        public static PayPalConfig getPayPalConfig(IConfiguration configuration)
        {
            return new PayPalConfig()
            {
                AuthToken = configuration["PayPal:AuthToken"],
                Business = configuration["PayPal:Business"],
                PostUrl = configuration["PayPal:PostUrl"],
                ReturnUrl = configuration["PayPal:ReturnUrl"]
            };
        }
    }
}
