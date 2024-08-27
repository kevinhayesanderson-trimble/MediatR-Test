using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    internal static class ServiceExtention
    {
        public static IServiceCollection RegisterMediatR(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(ServiceExtention).Assembly);
            });
        }
    }
}
