using Microsoft.IO;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddWebApiServices(this IServiceCollection services)
        {
            services.AddRepositories();

            services.AddSingleton<RecyclableMemoryStreamManager>();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<ItlSysContext>(ServiceLifetime.Scoped);

            services.AddScoped<ItlSysConnectionStringConfiguration>(); 

            services.AddScoped<IClienteRepository, ClienteRepository>();

            return services;
        }
    }
}
