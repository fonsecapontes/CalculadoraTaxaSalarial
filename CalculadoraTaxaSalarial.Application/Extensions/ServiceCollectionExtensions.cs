using CalculadoraTaxaSalarial.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CalculadoraTaxaSalarial.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDependencyInjectionCustom(this IServiceCollection services, IConfiguration configuration)
        {
            Container.RegisterServices(services);            
        }
    }
}
