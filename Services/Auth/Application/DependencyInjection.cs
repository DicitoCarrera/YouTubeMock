using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration: cfg =>
            cfg.RegisterServicesFromAssembly(assembly: typeof(DependencyInjection).Assembly));

        return services;
    }
}