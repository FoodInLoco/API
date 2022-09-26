using Microsoft.Extensions.Configuration;

namespace FoodInLoco.Application.Extensions
{
    public static class ConfigurationRootExtensions
    {
        public static IConfigurationRoot Configuration(this IConfigurationBuilder configuration)
        {
            return configuration.AddEnvironmentVariables().Build();
        }
    }
}
