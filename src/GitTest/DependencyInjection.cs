using Microsoft.Extensions.DependencyInjection;

namespace GitTest;

public static class DependencyInjection
{
    public static IServiceCollection AddMagic(this IServiceCollection services, Action<MagicConfigurationBuilder> configure)
    {
        var builder = new MagicConfigurationBuilder(services);
        configure(builder);
        services.AddSingleton(builder.Build());
        return services;
        return services;
    }
}