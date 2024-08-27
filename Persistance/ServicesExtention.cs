using Microsoft.Extensions.DependencyInjection;

namespace Persistance
{
    public static class ServicesExtention
    {
        public static IServiceCollection RegisterPersistance(this IServiceCollection serviceCollection)
        {
           serviceCollection.AddDbContext<ItemDbContext>(options =>
           {
               options.EnableSensitiveDataLogging();
           });
            serviceCollection.AddTransient<IRepository<Item>, EntityFrameworkRepository<Item>>();
            serviceCollection.AddSingleton<IReadStore<Item>, ReadStore<Item>>();
            return serviceCollection;
        }
    }
}
