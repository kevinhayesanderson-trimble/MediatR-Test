using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public static class ServiceExtension
    {
        public static IServiceCollection RegisterMediatR(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(ServiceExtension).Assembly);
            });
        }
    }
}
